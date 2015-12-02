using NFX;
using NFX.Environment;
using NFX.Serialization.JSON;
using NUnit.Framework;
using System;
using System.Linq;

namespace NFXDemos.Config.CommandArgsAndJSON
{

    public class Program
    {

        public static void CommandArgsToConfig()
        {
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

            Console.WriteLine("========== Command args to laconic ==========");
            Console.WriteLine(conf.ToLaconicString());
            Console.WriteLine();

            Assert.AreEqual(@"tool.exe", conf.Root.AttrByIndex(0).ValueAsString());
            Assert.AreEqual(@"c:\input.file", conf.Root.AttrByIndex(1).ValueAsString());
            Assert.AreEqual(@"d:\output.file", conf.Root.AttrByIndex(2).ValueAsString());

            Assert.AreEqual(true, conf.Root["compress"].Exists);
            Assert.AreEqual(100, conf.Root["compress"].AttrByName("level").ValueAsInt());
            Assert.AreEqual("zip", conf.Root["compress"].AttrByName("method").ValueAsString());

            Assert.AreEqual(true, conf.Root["shadow"].Exists);
            Assert.AreEqual("fast", conf.Root["shadow"].AttrByIndex(0).Value);
            Assert.AreEqual(1024, conf.Root["shadow"].AttrByName("swap").ValueAsInt());

            Assert.AreEqual(true, conf.Root["large"].Exists);
        }

        public static void ConfigToJSON()
        {
            var node = @"options 
                  { 
                    details=true 
                    disks 
                    { 
                      master { name='Toshiba' size=50} 
                      slave { name='Hitachi' size=100 archive=true} 
                    }
                  }".AsLaconicConfig();

            var map = node.ToJSONDataMap();

            Console.WriteLine("============== Laconic to JSON ==============");
            Console.WriteLine(map.ToJSON());
            Console.WriteLine();
        }

        public static void JSONToConfig()
        {
            var map = (JSONDataMap)@"{ 
                                  details: true, 
                                  disks:
                                  { 
                                    master: { name: 'Toshiba', size:50}, 
                                    slave:  { name: 'Hitachi', size:100, archive: true} 
                                  }
                                }".JSONToDataObject();

            var cfg = map.ToConfigNode();

            Console.WriteLine("============== JSON to laconic ==============");
            Console.WriteLine(cfg.ToLaconicString());
            Console.WriteLine();
        }

        static void Main(string[] arguments)
        {
            CommandArgsToConfig();

            ConfigToJSON();

            JSONToConfig();

            Console.ReadLine();
        }
    }
}
