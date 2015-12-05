using System;
using System.Globalization;
using System.Text;
using System.Threading;
using Config.NavigationAndEvaluation;
using NFX;
using NFX.ApplicationModel;
using NFX.Environment;

namespace NFXDemos.Config.NavigationAndEvaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var app = new ServiceBaseApplication(args, null))
                {
                    Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

                    var root = app.ConfigRoot;

                    Console.WriteLine("root.Name = " + root.Name);
                    Console.WriteLine("root.Value = " + root.Value);
                    Console.WriteLine("root.AttrByName(\"atr1\").Value = " + root.AttrByName("atr1").Value);
                    Console.WriteLine("root.AttrByIndex(1).Value = " + root.AttrByIndex(1).Value);
                    Console.WriteLine("root[\"logs\"].Value = '" + root["logs"].Value + "'");
                    Console.WriteLine("root[\"logs\"].AttrByName(\"file\").Value = " + root["logs"].AttrByName("file").Value);

                    Console.WriteLine();
                    Console.WriteLine("root.Navigate(\"/vars/path1/$[0]\").Value = " + root.Navigate("/vars/path1/$[0]").Value);
                    Console.WriteLine("root.Navigate(\"/vars/many/a[2]\").ValueAsInt() = " + root.Navigate("/vars/many/a[2]").ValueAsInt());
                    Console.WriteLine("root.Navigate(\"/vars/many/a[value=1]\").Value = " + root.Navigate("/vars/many/a[value=1]").Value);
                    Console.WriteLine(" and symbol '|' stands for alternative path:");
                    Console.WriteLine("root.Navigate(\"/vars/paff1/$value|/vars/path2/$value\").Value = " + root.Navigate("/vars/paff1/$value|/vars/path2/$value").Value);

                    Console.WriteLine();
                    Console.WriteLine("root[\"vars\"][\"path2\"].RootPath = " + root["vars"]["path2"].RootPath);
                    Console.WriteLine("root[\"vars\"][\"path2\"].AttrByIndex(0).RootPath = " + root["vars"]["path2"].AttrByIndex(0).RootPath);
                    Console.WriteLine("root[\"vars\"][\"many\"][0].RootPath = " + root["vars"]["many"][0].RootPath);
                    Console.WriteLine("root[\"vars\"][\"many\"][1].AttrByIndex(0).RootPath = " +root["vars"]["many"][1].AttrByIndex(0).RootPath);

                    Console.WriteLine();
                    Console.WriteLine("root[\"vars\"][\"var1\"].Value = " + root["vars"]["var1"].Value);
                    Console.WriteLine("root[\"vars\"][\"var1\"].VerbatimValue = " + root["vars"]["var1"].VerbatimValue);
                    Console.WriteLine("root[\"vars\"][\"var2\"].Value = " + root["vars"]["var2"].Value);
                    Console.WriteLine("root[\"vars\"][\"var2\"].VerbatimValue = " + root["vars"]["var2"].VerbatimValue);
                    Console.WriteLine("root[\"history\"].AttrByName(\"name\").Value = " + root["history"].AttrByName("name").Value);
                    Console.WriteLine("root[\"history\"].AttrByName(\"name\").ValueAsString(verbatim: true) = " + root["history"].AttrByName("name").ValueAsString(verbatim: true));

                    Console.WriteLine();
                    Console.WriteLine("root[\"history\"].AttrByName(\"text\").Value = " + root["history"].AttrByName("text").Value);
                    Console.WriteLine("root[\"logger\"].AttrByName(\"location\").Value = " + root["logger"].AttrByName("location").Value);

                    Console.WriteLine();
                    var bytes = root.AttrByName("bytes").ValueAsByteArray();
                    Console.WriteLine("bytes = " + BytesToString(bytes));
                    Console.WriteLine("root.AttrByName(\"vGUID\").ValueAsGUID(Guid.Empty) = " + root.AttrByName("vGUID").ValueAsGUID(Guid.Empty));

                    // after exception, stack should cleanup and work again as expected
                    Console.WriteLine();
                    try
                    {
                        var v2 = root["data"]["extra"].AttrByName("cycle").Value;  //exception
                    }
                    catch
                    {
                        Console.WriteLine("We will get the endless loop if we try to get\r\nroot[\"data\"][\"extra\"].AttrByName(\"cycle\").Value");
                    }

                    Console.WriteLine();
                    Console.WriteLine("IsNullOrEmpty(root[\"optional\"].Value) = " + string.IsNullOrEmpty(root["optional"].Value));
                    Console.WriteLine("Try to get root[\"required\"].Value...");
                    try
                    {
                        var v = root["required"].Value;  //exception
                    }
                    catch
                    {
                        Console.WriteLine("and have exception due to symbol '!' means that path has to exist.");
                    }

                    Console.WriteLine();
                    Console.WriteLine(root.Navigate("/varEscaped").Value + " because of $(###).");

                    Console.WriteLine();
                    Console.WriteLine("Using default environment variable resolver and macro context:");
                    Console.WriteLine(" OS = " + root.Navigate("data/extra/$env").Value);
                    Console.WriteLine(" Now is = " + root.Navigate("data/extra/$dt").ValueAsDateTime(DateTime.MinValue).ToString());

                    Console.WriteLine();
                    Console.WriteLine("Using environment variable resolver:");
                    var resolver = new VarsResolver();
                    root.Configuration.EnvironmentVarResolver = resolver;
                    Console.WriteLine(" root[\"env1\"].Value = " + root["env1"].Value);
                    Console.WriteLine(" root[\"env2\"].Value = " + root["env2"].Value);

                    Console.WriteLine();
                    Console.WriteLine("Evaluation from string:");
                    Console.WriteLine(" Hello $(vars/var1) and $(vars/var1) = " + "Hello $(vars/var1) and $(vars/var1)".EvaluateVarsInConfigScope(root.Configuration));
                    Console.WriteLine(" Hello $(/$v)! = " + "Hello $(/$v)!".EvaluateVarsInXMLConfigScope("<a v='123'> </a>"));

                    Console.WriteLine();
                    Console.WriteLine("Evaluation from string with variable resolver:");
                    Console.WriteLine(" What is the result of $(~A)+$(~B)? = " + "What is the result of $(~A)+$(~B)?".EvaluateVars(resolver));
                    Console.WriteLine(" $(~GreEtInG), your age is $(~AGE)! = " + "$(~GreEtInG), your age is $(~AGE)".EvaluateVars(new Vars{
                            {"Greeting", "Hello"},
                            {"Age", "25"}}));
                    Console.WriteLine(" This happened in $(~C::as-dateTime fmt=\"{0:MM/yyyy}\") = " + "This happened in $(~C::as-dateTime fmt=\"{0:MM/yyyy}\")".EvaluateVars(resolver));
                    Console.WriteLine(" $(/$name::as-string dflt=\"James\"), the value is $(/dont-exist::as-int dflt=\"12\"). = " +
                                     "$(/$name::as-string dflt=\"James\"), the value is $(/dont-exist::as-int dflt=\"12\").".EvaluateVars());
                    Console.WriteLine(" $(~name::as-string dflt=\"James\"), the value is $(/dont-exist::as-int dflt=\"12\"). = " +
                                    "$(~name::as-string dflt=\"James\"), the value is $(/dont-exist::as-int dflt=\"12\").".EvaluateVars(
                                     new Vars { { "name", "Spenser" } }));
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

        public static string BytesToString(byte[] bytes)
        {
            if (bytes == null)
                return "null";
            var res = new StringBuilder("[");
            var len = bytes.Length - 1;
            for (var i = 0; i < len; i++)
            {
                res.Append(string.Format("{0:X}", bytes[i]) + ", ");
            }
            res.Append(string.Format("{0:X}", bytes[len]) + "]");
            return res.ToString();
        }
    }  
}
