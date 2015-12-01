using NFX.ApplicationModel;
using NFX.Environment;
using System;
using System.Threading;

namespace NFXDemos.Config.Scripting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            try
            {
                using (var app = new ServiceBaseApplication(args, null))
                {
                    var src = app.ConfigRoot;
                    var res = new NFX.Environment.LaconicConfiguration();
                    new ScriptRunner().Execute(src.Configuration, res);
                    Console.WriteLine(res.SaveToString());
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Critical error:");
                Console.WriteLine(ex.Message);
                Environment.ExitCode = -1;
                Console.ReadLine();
            }
        }
    }
}
