using NFX.ApplicationModel;
using NFX.CodeAnalysis.Laconfig;
using NFX.Environment;
using NUnit.Framework;
using System;


namespace NFXDemos.Config.NavigationAndEvaluation
{
    class Program
    {

        static string MakeConfigAndSaveToString()
        {
            var conf = new LaconicConfiguration();
            conf.Create("root");
            conf.Root.AddChildNode("child1").AddAttributeNode("attr", "first");
            conf.Root.AddChildNode("child2").AddAttributeNode("attr", "second");
            conf.Root["child2"].Value = "node2";

            conf.Root.AddChildNode("child3").AddChildNode("child3.1").AddAttributeNode("attr","third");

            var tmp = LaconicConfiguration.CreateFromString("root{ child4=4 { attr=fourth}}");
            conf.Root.AddChildNode(tmp.Root["child4"]);


            return conf.SaveToString(LaconfigWritingOptions.PrettyPrint);
        }

        static void SomeManipulations()
        {
            string src = @"root {A{}}";
            var conf = LaconicConfiguration.CreateFromString(src);

            Assert.IsFalse(conf.Root.Modified);
            conf.Root["A"].Value = "aaa";
            Assert.AreEqual("aaa", conf.Root.Navigate("A").Value);
            Assert.IsTrue(conf.Root.Modified);
            conf.Root.ResetModified();
            Assert.IsFalse(conf.Root.Modified);

            conf.Root.AddChildNode("C", null);
            Assert.AreEqual("C", conf.Root["C"].Name);
            conf.Root["C"].Name = "B";
            Assert.AreEqual("B", conf.Root["B"].Name);

            Assert.AreEqual(true, conf.Root["A"].Exists);
            conf.Root["A"].Delete();
            Assert.AreEqual(false, conf.Root["A"].Exists);

            Assert.AreEqual(true, conf.Root.Exists);
            conf.Root.Delete();
            Assert.AreEqual(false, conf.Root.Exists);
        }

        static void Main(string[] args)
        {
            try
            {
                using (var app = new ServiceBaseApplication(args, null))
                {
                    var root = app.ConfigRoot;

                    Assert.AreEqual("root", root.Name);
                    Assert.AreEqual("laconic", root.Value);
                    Assert.AreEqual("val1", root.AttrByName("atr1").Value);
                    Assert.AreEqual("val2", root.AttrByIndex(1).Value);
                    Assert.AreEqual("value{3}", root.AttrByName("atr 3").Value);

                    Assert.AreEqual("13 14", root["logs"].Value);
                    Assert.AreEqual("abc.txt", root["logs"].AttrByName("file").Value);

                    Assert.AreEqual("val1", root["vars"]["var1"].Value);
                    Assert.AreEqual("val1", root["vars"]["var1"].VerbatimValue);

                    Assert.AreEqual("val1", root["vars"]["var2"].Value);
                    Assert.AreEqual("$(../var1)", root["vars"]["var2"].VerbatimValue);

                    Assert.AreEqual("val1", root["history"].AttrByName("name").Value);
                    Assert.AreEqual("$(/vars/var1)", root["history"].AttrByName("name").ValueAsString(verbatim: true));

                    Assert.AreEqual("This happened on 1982/05/12.", root["history"].AttrByName("text").Value);

                    Assert.AreEqual(@"c:\logs\critical", root["logger"].AttrByName("location").Value);

                    var bytes = root.AttrByName("bytes").ValueAsByteArray();
                    Assert.AreEqual(3, bytes.Length);
                    Assert.AreEqual(0x3d, bytes[0]);
                    Assert.AreEqual(0x12, bytes[1]);
                    Assert.AreEqual(0xff, bytes[2]);

                    Assert.AreEqual(new Guid("3A7C4641B24E453D9D2893D96071B575"), root.AttrByName("vGUID1").ValueAsGUID(Guid.Empty));
                    Assert.AreEqual(new Guid("3A7C4641B24E453D9D2893D96071B575"), root.AttrByName("vGUID2").ValueAsGUID(Guid.Empty));
                    Assert.AreEqual(new Guid("3A7C4641B24E453D9D2893D96071B575"), root.AttrByName("vGUID3").ValueAsGUID(Guid.Empty));

                    try
                    {
                        var v2 = root["data"]["extra"].AttrByName("cycle").Value;  //exception
                    }
                    catch
                    {
                        Console.WriteLine("We got the endless loop!");
                    }

                    //after exception, stack should cleanup and work again as expected
                    Assert.AreEqual("val1", root["vars"]["var1"].Value);

                    Assert.AreEqual(true, string.IsNullOrEmpty(root["optional"].Value));

                    try
                    {
                        var v = root["required"].Value;  //exception
                    }
                    catch
                    {
                        Console.WriteLine("Variable is required!");
                    }

                    Assert.AreEqual("This is not var: $(../AAA)", root.Navigate("/varEscaped").Value);
                    

                    Console.WriteLine("OS = "+root.Navigate("data/extra/$env").Value);
                    Console.WriteLine("Now is = " + root.Navigate("data/extra/$dt").ValueAsDateTime(DateTime.MinValue).ToString());

                    Assert.AreEqual("c:\\logs\\", root.Navigate("/vars/path1/$[0]").Value);
                    Assert.AreEqual("\\critical", root.Navigate("/vars/paff1/$value|/vars/path2/$value").Value);
                    
                    Assert.AreEqual(2, root.Navigate("/vars/many/a[2]").ValueAsInt());
                    Assert.AreEqual("1", root.Navigate("/vars/many/a[value=1]").Value);

                    Assert.AreEqual("/vars/path2", root["vars"]["path2"].RootPath);
                    Assert.AreEqual("/vars/path2/$value", root["vars"]["path2"].AttrByIndex(0).RootPath);
                    Assert.AreEqual("/vars/many/[0]", root["vars"]["many"][0].RootPath);
                    Assert.AreEqual("/vars/many/[1]/$value", root["vars"]["many"][1].AttrByIndex(0).RootPath);
                    
                    SomeManipulations();

                    Console.WriteLine(MakeConfigAndSaveToString());

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
