using NFX;
using NFX.ApplicationModel;
using NFX.Environment;
using System;

namespace NFXDemos.Config.IncludeOverrideMerge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DemonstrateInclude();

            // Uncomment to see how a sub-tree from external file includes in existing configuration.
            //DemonstrateIncludePragma();

            // Uncomment to see the result of two configurations merging.
            //DemonstrateOverrideAndMerge();

            Console.ReadLine();
        }

        /// <summary>
        /// Demonstrates direct inclusion sub-tree in configuration (with comlplete replacement existing node).
        /// </summary>
        public static void DemonstrateInclude()
        {
            string cfg1 =
                @"root
                  {
                    section-a
                    {
                      attr='A'
                      sub-sect='Sub Value A' {}
                    }
                    
                    section-b
                    {
                      attr='B'
                      sub-sect='Sub Value B' {}
                    }
                  }";
            string cfg2 =
                @"root
                  {
                     section-c
                     {
                        attr='c'
                        sub-sect='Sub Value C' {}
                     }
                  }";

            var conf1 = LaconicConfiguration.CreateFromString(cfg1);
            var conf2 = LaconicConfiguration.CreateFromString(cfg2);

            Console.WriteLine("======================= BEFORE INCLUDE ==========================");
            Console.WriteLine(conf1.ToLaconicString());
            Console.WriteLine();

            conf1.Include(conf1.Root["section-a"], conf2.Root);

            Console.WriteLine("======================= AFTER INCLUDE ===========================");
            Console.WriteLine(conf1.ToLaconicString());
            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates using "_include" pragma to add in configuration a sub-tree from external file.
        /// </summary>
        public static void DemonstrateIncludePragma()
        {
            var conf = 
                @"root
                  {
                    a=100
                     
                    _include
                    {
                      name=WithNewName
                      file=$""Resources\incl.laconf""
                    }

                    _include
                    {
                      //without name
                      file=$""Resources\incl.laconf""
                    }
                  }".AsLaconicConfig();

            Console.WriteLine("============== BEFORE PROCESS INCLUDE PRAGMAS ==================");
            Console.WriteLine(conf.ToLaconicString());
            Console.WriteLine();

            conf.ProcessIncludePragmas(true);

            Console.WriteLine("============== AFTER PROCESS INCLUDE PRAGMAS ==================");
            Console.WriteLine(conf.ToLaconicString());
            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates merging of two configurations.
        /// Please see "Config.IncludeOverrideMerge.laconf" file to view the application configuration
        /// before merging (var conf1 in code).
        /// </summary>
        public static void DemonstrateOverrideAndMerge()
        {
            string cfg2 =
                   @"root
                     {
                       section-a
                       {
                         newattr='new val'
                         sub2='The new Sub Value 2' {}
                         destination
                         {
                           name='B'
                           type='XML'
                         }
                       }

                       section-b
                       {
                         age='89'
                         pension='true'
                         name='James' {}
                       } 

                       section-c='Could cause failure while merging.' {}

                       section-d='This section will be ignored.' { all='yes' }

                       section-e
                       {
                         some-attr='999'
                         demo='Demo!'
                       }

                       section-f
                       {
                         _clear {}
                         some-attr='321'
                         some-new-attr='ignored'
                         flag { checked='true' }
                       }
                     }";

            var conf2 = LaconicConfiguration.CreateFromString(cfg2);
            var conf = new NFX.Environment.MemoryConfiguration();

            try
            {
                using (var app = new ServiceBaseApplication(null, null))
                {
                    var conf1 = app.ConfigRoot;
                    conf.CreateFromMerge(conf1, conf2.Root);

                    Console.WriteLine("======================= AFTER MERGING ==========================");
                    Console.WriteLine(conf.ToLaconicString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Critical error:");
                Console.WriteLine(ex.Message);
                Environment.ExitCode = -1;
            }
        }
    }
}
