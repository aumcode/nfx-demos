using System;
using NFX.Wave.MVC;
using Wave.HelloWorld.Pages;

namespace Wave.HelloWorld.Controllers
{
    public class Hello : Controller
    {
        [Action]
        public object Index()
        {
            return new Index();
        }
    }
}
