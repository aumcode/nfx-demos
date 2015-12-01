using NFX.Environment;

namespace Config.Attributes.Classes
{
    public class AttrClassExtended : AttrClass
    {

        [Config("$pvt-int-extended")]
        private int m_PrivateInt; public int getPrivateIntExtended() { return m_PrivateInt; }


        private int m_privateProperty;

        [Config("$pvt-property-extended")]
        private int privateProperty
        {
            get { return m_privateProperty; }
            set { m_privateProperty = value; }
        }
        public int getPrivatePropertyExtended() { return privateProperty; }


        //notice no attributes on this level, they will get inherited here
        [Config("abrakabadra", "So what?")]
        public string NoneAnotherString { get; set; }
    }
}
