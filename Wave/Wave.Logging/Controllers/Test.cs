using NFX.Wave.MVC;
using Wave.Logging.Pages;

namespace Wave.Logging.Controllers
{
    public class Test : Controller
    {
        [Action]
        public object Index()
        {
            return new Index();
        }

        [Action]
        public object Another()
        {
            return new Another();
        }
    }
}
