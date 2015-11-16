using System.Linq;
using System.Collections.Generic;
using NFX.Environment;
using NFX.Wave;
using NFX;

namespace Wave.FilteringAndHandling.Customization
{
    /// <summary>
    /// Custom filter that redirects any matched URL to some another MVC action within the same controller
    /// http://localhost:8080/Test/OldAction --> http://localhost:8080/Test/NewAction
    /// </summary>
    public class CustomFilter : WorkFilter
    {
        #region CONSTS

        public const string VAR_NEW_ACTION = "new-action";

        #endregion

        #region .ctor

        public CustomFilter(WorkDispatcher dispatcher, string name, int order) : base(dispatcher, name, order)
        {
        }

        public CustomFilter(WorkDispatcher dispatcher, IConfigSectionNode confNode) : base(dispatcher, confNode)
        {
            configureMatches(confNode);
        }

        public CustomFilter(WorkHandler handler, string name, int order) : base(handler, name, order)
        {
        }

        public CustomFilter(WorkHandler handler, IConfigSectionNode confNode) : base(handler, confNode)
        {
            configureMatches(confNode);
        }

        #endregion

        #region Fields

        private readonly OrderedRegistry<WorkMatch> m_Matches = new OrderedRegistry<WorkMatch>();

        #endregion

        protected override void DoFilterWork(WorkContext work, IList<WorkFilter> filters, int thisFilterIndex)
        {
            foreach (var match in m_Matches.OrderedValues)
            {
                var matched = match.Make(work);
                if (matched == null)
                    continue;

                var newAction = matched[VAR_NEW_ACTION].AsString();
                if (newAction.IsNullOrWhiteSpace())
                    continue;

                var oldUrl = work.Request.Url.ToString();
                var newUrl = changeMvcUrlAction(oldUrl, newAction);
                if (newUrl == null)
                    continue;

                work.Response.RedirectAndAbort(newUrl);
            }

            this.InvokeNextWorker(work, filters, thisFilterIndex);
        }

        #region .pvt

        private void configureMatches(IConfigSectionNode confNode)
        {
            foreach (var node in confNode.Children.Where(n => n.IsSameName(WorkMatch.CONFIG_MATCH_SECTION)))
            {
                var match = FactoryUtils.Make<WorkMatch>(node, typeof(WorkMatch), args: new object[] { node });
                var result = m_Matches.Register(match);
                if (!result)
                    throw new WaveException("Match {0} specified more than once".Args(match.Name));
            }
        }

        private static string changeMvcUrlAction(string oldUrl, string newAction)
        {
            var minIdx = indexOf(oldUrl, "/", 0, 4);
            if (minIdx == -1)
                return null;

            var maxIdx = indexOf(oldUrl, "/", 0, 5);
            if (maxIdx == -1)
                maxIdx = oldUrl.Length - 1;

            var prefix = oldUrl.Substring(0, minIdx);
            var suffix = oldUrl.Substring(maxIdx + 1, oldUrl.Length - maxIdx - 1);
            var newUrl = "{0}/{1}/{2}".Args(prefix, newAction, suffix);

            return newUrl;
        }

        private static int indexOf(string source, string find, int from, int count)
        {
            if (count <= 0 || source == null || find == null)
                return -1;

            var idx = source.IndexOf(find, from);
            if (idx == -1)
                return -1;

            if (count == 1)
                return idx;

            return indexOf(source, find, idx + 1, count - 1);
        }

        #endregion
    }
}
