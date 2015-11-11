using NFX.Wave.MVC;
using Wave.Resources.Pages;

namespace Wave.Resources.Controllers
{
    public class Test : Controller
    {
        [Action]
        public object Index()
        {
            return new Index();
        }
    }
}
