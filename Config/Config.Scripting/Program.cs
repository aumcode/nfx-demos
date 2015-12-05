using System;
using System.Globalization;
using System.Threading;
using NFX.ApplicationModel;
using NFX.Environment;

namespace NFXDemos.Config.Scripting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            try
            {
                using (var app = new ServiceBaseApplication(args, null))
                {
                    var src = app.ConfigRoot;
                    var res = new LaconicConfiguration();
                    var runner = new ScriptRunner();
                    runner.Execute(src.Configuration, res);
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
