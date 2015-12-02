using NFX;
using NFX.ApplicationModel;
using NFX.Environment;
using System;

namespace NFXDemos.Config.IncludeOverrideMerge
{
    public class Program
    {
        public static void DemonstrateInclude()
        {
            string cfg1 =
                @"root
                  {
                     section-a
                     {
                        attr='a'
                        sub-sect='Sub Value A' {attr='aA'}
                     }

                    section-b
                    {
                       sub-sect='Sub Value B' {}
                    }
                }";

            string cfg2 =
                @"root
                  {
                     section-c
                     {
                        attr='c'
                        sub-sect='Sub Value C' { attr='cC' }
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

        public static void DemonstrateOverrideAndMerge()
        {
            string cfg2 =
                   @"root
                     {
                        section-a
                        {
                           newattr='new val'
                           sub2='Sub Value 2 ammended'{}
                           sub3='Sub Value 3'{}
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
                           name='James'{}
                        } 

                        section-c='Could cause failure' {}

                        section-d='This will be ignored' { all='yes' }

                        section-e
                        {
                           some-attr='999'
                           demo='Demo!'
                        }

                        section-f
                        {
                           _clear{}
                           some-attr='321'
                           flag { checked='yes' }
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

        public static void Main(string[] args)
        {
            DemonstrateInclude();
            DemonstrateIncludePragma();
            DemonstrateOverrideAndMerge();
            Console.ReadLine();
        }
    }
}
