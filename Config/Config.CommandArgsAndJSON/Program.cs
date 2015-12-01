using NFX;
using NFX.Environment;
using NFX.Serialization.JSON;
using NUnit.Framework;
using System;
using System.Linq;

namespace NFXDemos.Config.CommandArgsAndJSON
{

    class Program
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
            var node = @"opt 
                  { 
                    detailed-instrumentation=true 
                    tables 
                    { 
                      master { name='tfactory' fields-qty=14} 
                      slave { name='tdoor' fields-qty=20 important=true} 
                    }
                  }".AsLaconicConfig();

            var map = node.ToJSONDataMap();

            Assert.AreEqual(2, map.Count);
            Assert.IsTrue(map["detailed-instrumentation"].AsString() == "true");

            var tablesMap = (JSONDataMap)map["tables"];

            var master = (JSONDataMap)tablesMap["master"];
            Assert.IsTrue(master["name"].AsString() == "tfactory");
            Assert.IsTrue(master["fields-qty"].AsString() == "14");

            var slave = (JSONDataMap)tablesMap["slave"];
            Assert.IsTrue(slave["name"].AsString() == "tdoor");
            Assert.IsTrue(slave["fields-qty"].AsString() == "20");
            Assert.IsTrue(slave["important"].AsString() == "true");
        }

        public static void JSONToConfig()
        {
            var map = (JSONDataMap)@" { 
                                  'detailed-instrumentation': true, 
                                  tables:
                                  { 
                                    master: { name: 'tfactory', 'fields-qty': 14}, 
                                    slave: { name: 'tdoor', 'fields-qty': 20, important: true} 
                                  }
                                }".JSONToDataObject();

            var cfg = map.ToConfigNode();

            Assert.AreEqual(1, cfg.Attributes.Count());
            Assert.AreEqual(1, cfg.Children.Count());

            Assert.IsTrue(cfg.AttrByName("detailed-instrumentation").ValueAsBool());

            var tablesNode = cfg.Children.Single(ch => ch.Name == "tables");

            var master = cfg.NavigateSection("tables/master");
            Assert.AreEqual(2, master.Attributes.Count());
            Assert.IsTrue(master.AttrByName("name").ValueAsString() == "tfactory");
            Assert.IsTrue(master.AttrByName("fields-qty").ValueAsInt() == 14);

            var slave = cfg.NavigateSection("tables/slave");
            Assert.AreEqual(3, slave.Attributes.Count());
            Assert.IsTrue(slave.AttrByName("name").ValueAsString() == "tdoor");
            Assert.IsTrue(slave.AttrByName("fields-qty").ValueAsInt() == 20);
            Assert.IsTrue(slave.AttrByName("important").ValueAsBool());
        }

        static void Main(string[] arguments)
        {
            CommandArgsToConfig();

            ConfigToJSON();

            JSONToConfig();

            Console.WriteLine("Well done!");
            Console.ReadLine();
        }
    }
}
