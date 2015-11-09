using NFX.Wave.MVC;
using Wave.FilteringAndHandling.Pages;

namespace Wave.FilteringAndHandling.Controllers
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
