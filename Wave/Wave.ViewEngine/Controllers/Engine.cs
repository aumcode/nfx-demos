using NFX.Wave.MVC;
using Wave.HelloWorld.Pages;

namespace Wave.ViewEngine.Controllers
{
    public class Engine : Controller
    {
        [Action]
        public object TestLocalVars()
        {
            string name = "Jack";
            int age = 36;
            return new LocalVars { Name = name, Age = age };
        } 
    }
}
