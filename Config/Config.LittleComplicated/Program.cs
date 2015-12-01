using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFXDemos.Config.LittleComplicated
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.AreEqual("Hello val1val1!", "Hello $(vars/var1)$(vars/var1)!".EvaluateVarsInConfigScope(root.Configuration));
            Assert.AreEqual("Hello 123!", "Hello $(/$v)!".EvaluateVarsInXMLConfigScope("<a v='123'> </a>"));

            Assert.AreEqual("Hello, your age is 20", "$(~GreEtInG), your age is $(~AGE)".EvaluateVars(new Vars{
                            {"Greeting", "Hello"},
                            {"Age", "20"}}));

            Assert.AreEqual("Time is 01/18/1901 2:03PM", "Time is $(~C)".EvaluateVars(new MyVars()));

            Assert.AreEqual("Time is 01/1901", "Time is $(~C::as-dateTime fmt=\"{0:MM/yyyy}\")".EvaluateVars(new MyVars()));

            Assert.AreEqual("Time is Month=01 Year=1901", "Time is $(~C::as-dateTime fmt=\"Month={0:MM} Year={0:yyyy}\")".EvaluateVars(new MyVars()));

            Assert.AreEqual("Value is 12 OK?", "Value is $(/dont-exist::as-int dflt=\"12\") OK?".EvaluateVars());

            Assert.AreEqual("James, the value is 12 OK?",
                           "$(/$name::as-string dflt=\"James\"), the value is $(/dont-exist::as-int dflt=\"12\") OK?".EvaluateVars());

            Assert.AreEqual("Mark Spenser, the value is 12 OK?",
                           "$(~name::as-string dflt=\"James\"), the value is $(/dont-exist::as-int dflt=\"12\") OK?".EvaluateVars(
                            new Vars { { "name", "Mark Spenser" } }
                           ));

            Assert.AreEqual("20131012-06", "$(::now fmt=yyyyMMdd-HH value=20131012-06)".EvaluateVars());
        }
    }
}
