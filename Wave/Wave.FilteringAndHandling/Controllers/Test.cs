using NFX;
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

        [Action]
        public object Box(string color)
        {
            color = color ?? "458b00";
            return new Box { Color = "#{0}".Args(color) };
        }
    }
}
