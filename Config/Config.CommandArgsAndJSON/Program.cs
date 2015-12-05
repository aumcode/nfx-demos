using System;
using NFX;
using NFX.Environment;
using NFX.Serialization.JSON;

namespace NFXDemos.Config.CommandArgsAndJSON
{
    public class Program
    {
        public static void Main(string[] arguments)
        {
            CommandArgsToConfig();

            // Uncomment appropriate statement to see examples with config <--> JSON transformation.
            //ConfigToJSON();
            //JSONToConfig();

            Console.ReadLine();
        }

        /// </summary>
        ///  Demonstrates generation of configuration based on arguments supplied from command line
        ///  which is "string[]". Arguments start with either "/" or "-" prefix. If any argument is not 
        ///  prefixed then it is written as an auto-named ("?<index>") attribute node of the root with its value set,
        ///  otherwise a section (under root) with argument's name is created.
        ///  Any argument may have options. Any option may either consist of name or name value pair delimited by "=".
        ///  Argument options are written as attribute nodes of their corresponding sections.
        ///  If option value specified without name (without "=") then option is auto-named.
        /// </summary>
        public static void CommandArgsToConfig()
        {
            // example of command string arguments
            string[] args =
               {
                    @"tool.exe",
                    @"c:\input.file",
                    @"d:\output.file",
                    @"-compress",
                    @"level=100",
                    @"method=zip",
                    @"-shadow",
                    @"fast",
                    @"swap=1024",
                    @"-large"
               };

            var conf = new CommandArgsConfiguration(args);

            Console.WriteLine("======== Command args to laconic ========");
            Console.WriteLine(conf.ToLaconicString());
            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates a generation of JSON data from coressponding configuration.
        /// </summary>
        public static void ConfigToJSON()
        {
            var node = 
                @"options 
                  { 
                    details=true 
                    disks 
                    { 
                      master { name='Toshiba' size=50 } 
                      slave { name='Hitachi' size=100 archive=false } 
                    }
                  }".AsLaconicConfig();

            var map = node.ToJSONDataMap();

            Console.WriteLine("============ Laconic to JSON ============");
            Console.WriteLine(map.ToJSON());
            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates a generation of configuration based on coressponding JSON data.
        /// </summary>
        public static void JSONToConfig()
        {
            var map = 
                (JSONDataMap)@"{ 
                                 details: true, 
                                 disks:
                                 { 
                                   master: { name: 'Toshiba', size:50 }, 
                                   slave:  { name: 'Hitachi', size:100, archive: false } 
                                 }
                               }".JSONToDataObject();

            var cfg = map.ToConfigNode();

            Console.WriteLine("============ JSON to laconic ============");
            Console.WriteLine(cfg.ToLaconicString());
            Console.WriteLine();
        }
    }
}
