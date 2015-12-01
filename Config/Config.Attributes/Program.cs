using Config.Attributes.Classes;
using NFX.ApplicationModel;
using NFX.Environment;
using NUnit.Framework;
using System;

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

                    var cl = new AttrClass();
                    ConfigAttribute.Apply(cl, conf);

                    Assert.AreEqual(-892, cl.getPrivateInt());
                    Assert.AreEqual(23567, cl.getPrivateProperty());

                    Assert.AreEqual("private", cl.getPrivateName());
                    Assert.AreEqual("protected", cl.getProtectedName());
                    Assert.AreEqual("public", cl.m_PublicName);

                    Assert.AreEqual("laconic", cl.Format);

                    Assert.AreEqual(99, cl.Age);
                    Assert.AreEqual(890, cl.Age2);
                    Assert.AreEqual(1890, cl.TheNewAge);

                    Assert.AreEqual(AttrEnum.B, cl.MyEnumField);

                    Assert.AreEqual(5, cl.When.Month);
                    Assert.AreEqual(12, cl.When.Day);
                    Assert.AreEqual(1982, cl.When.Year);

                    Assert.AreEqual(true, cl.Fuzzy.Value);

                    Assert.AreEqual(false, cl.Jazzy.HasValue);

                    Assert.AreEqual(155, cl.NoneInt);
                    Assert.AreEqual("This is default", cl.NoneString);
                    Assert.AreEqual(123.45, cl.NoneDouble);

                    var bytes = cl.Bytes;
                    Assert.AreEqual(3, bytes.Length);

                    Assert.AreEqual(0x3d, bytes[00]);
                    Assert.AreEqual(0x12, bytes[01]);
                    Assert.AreEqual(0xff, bytes[02]);

                    Assert.AreEqual("YES!", cl.OptionsProp["hello"].Value);
                    Assert.AreEqual(1, cl.OptionsProp["hello"].AttrByName("a").ValueAsInt());

                    Assert.AreEqual("YES!", cl.OptionsField["hello"].Value);
                    Assert.AreEqual(1, cl.OptionsField["hello"].AttrByName("a").ValueAsInt());

                    var cle = new AttrClassExtended();          // extended class
                    ConfigAttribute.Apply(cle, conf);

                    Assert.AreEqual(-892, cle.getPrivateInt());
                    Assert.AreEqual(23567, cle.getPrivateProperty());

                    Assert.AreEqual(+892, cle.getPrivateIntExtended());
                    Assert.AreEqual(-23567, cle.getPrivatePropertyExtended());

                    Assert.AreEqual("So what?", cle.NoneAnotherString);


                    var cle2 = new AttrClassExtended2();
                    ConfigAttribute.Apply(cle2, conf);      //extended class with root override

                    Assert.AreEqual("protected", cle2.getProtectedName());
                    Assert.AreEqual("public", cle2.m_PublicName);

                    Assert.AreEqual(199, cle2.Age);
                    Assert.AreEqual(AttrEnum.C, cle2.MyEnumField);

                    Assert.AreEqual(1, cle2.When.Month);
                    Assert.AreEqual(1, cle2.When.Day);
                    Assert.AreEqual(1944, cle2.When.Year);

                    Assert.AreEqual(false, cle2.Fuzzy.Value);

                    Assert.AreEqual(false, cle2.Jazzy.HasValue);

                    Console.WriteLine("Well done!");
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
