using NFX.Environment;

namespace Config.Attributes.Classes
{
    public class SomeClassExtended : SomeClass
    {
        [Config("$pvt-int-extended")]
        private int m_PrivateInt;

        [Config("$pub-int-extended")]
        public int PublicInt { get; set; }

        //notice no attributes on this level, they will get inherited here
        [Config("some-attribute", "this is a new string")]
        public string NoneAnotherString { get; set; }

        public int GetPrivateIntExtended()
        {
            return m_PrivateInt;
        }

        public override string ToString()
        {
            var s = base.ToString();
            return s + "new members:" + "\r\n"
                + "  GetPrivateInt (extended) = " + GetPrivateIntExtended() + "\r\n"
                + "  PublicInt (extended) = " + PublicInt + "\r\n"
                + "  NoneAnotherString = " + NoneAnotherString + "\r\n";
        }
    }
}
