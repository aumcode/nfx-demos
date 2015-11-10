using System.Collections.Generic;
using NFX;
using NFX.Parsing;
using NFX.Environment;
using NFX.Wave;

namespace Wave.FilteringAndHandling.Customization
{
    /// <summary>
    /// Custom handler that simply returns random persons data
    /// </summary>
    public class CustomHandler : WorkHandler
    {
        #region .ctor

        public CustomHandler(WorkDispatcher dispatcher, string name, int order, WorkMatch match)
            : base(dispatcher, name, order, match)
        {
        }

        public CustomHandler(WorkDispatcher dispatcher, IConfigSectionNode confNode)
            : base(dispatcher, confNode)
        {
        }

        #endregion

        protected override void DoHandleWork(WorkContext work)
        {
            var cnt = work.MatchedVars["cnt"].AsInt(10);
            var pretty = work.MatchedVars["pretty"].AsBool(true);

            if (cnt > 10000) cnt = 10000;
            if (cnt < 0) cnt = 1;

            var lst = new List<object>();

            for (var i = 0; i < cnt; i++)
            {
                lst.Add(new {
                    FirstName = NaturalTextGenerator.GenerateFirstName(),
                    MiddleName = NaturalTextGenerator.GenerateFirstName(),
                    LastName = NaturalTextGenerator.GenerateLastName(),
                    Address = "{0}\n{1}".Args(NaturalTextGenerator.GenerateAddressLine(),
                                              NaturalTextGenerator.GenerateUSCityStateZip()),
                    Email = NaturalTextGenerator.GenerateEMail()
                });
            }

            work.Response.WriteJSON(lst, pretty ? 
                                         NFX.Serialization.JSON.JSONWritingOptions.PrettyPrint :
                                         NFX.Serialization.JSON.JSONWritingOptions.Compact);
        }
    }
}
