using NFX.Wave.MVC;
using Wave.ViewEngine.Pages;

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

        [Action]
        public object TestStatements()
        {
            return new Statements();
        }

        [Action]
        public object TestMasterPage()
        {
            return new Page();
        }
    }
}
