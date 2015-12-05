using System;
using Config.Attributes.Classes;
using NFX.ApplicationModel;
using NFX.Environment;

namespace NFXDemos.Config.Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var app = new ServiceBaseApplication(args, null))
                {
                    var conf = app.ConfigRoot;

                    // Just an example of applying configuration to corresponding class.
                    var cl = new SomeClass();
                    ConfigAttribute.Apply(cl, conf);
                    Console.WriteLine("========== SomeClass ==========");
                    Console.WriteLine(cl.ToString());

                    // Applying configuration to class which extends the first one.
                    // Pay attention to difference between old and new members with same names.
                    var cle = new SomeClassExtended();          
                    ConfigAttribute.Apply(cle, conf);
                    Console.WriteLine("====== SomeClassExtended ======");
                    Console.WriteLine(cle.ToString());

                    // Applying configuration to class which extends the first one but the root was overriden.
                    // And members are initialized with value from new sub-tree if they have corresponding node only.
                    var cle2 = new SomeClassExtended2();
                    ConfigAttribute.Apply(cle2, conf);
                    Console.WriteLine("====== SomeClassExtended2 ======");
                    Console.WriteLine(cle2.ToString());

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
