using NFX.Environment;
using System;

namespace Config.Attributes.Classes
{
    public enum AttrEnum { A, B, C, D }

    [Config("AttrClass/data")]
    public class AttrClass
    {

        [Config("$pvt-int")]
        private int m_PrivateInt;
        public int getPrivateInt() { return m_PrivateInt; }


        private int m_privateProperty;

        [Config("$pvt-property")]
        private int privateProperty
        {
            get { return m_privateProperty; }
            set { m_privateProperty = value; }
        }

        public int getPrivateProperty() { return privateProperty; }



        [Config("$pvt-name")]
        private string m_PrivateName; public string getPrivateName() { return m_PrivateName; }

        [Config("$prot-name")]
        protected string m_ProtectedName; public string getProtectedName() { return m_ProtectedName; }

        [Config("$pub-name")]
        public string m_PublicName;

        [Config("$pub-format|$pub-def-format")]
        public string Format;

        [Config("$age")]
        public int Age;

        [Config]
        public int Age2;

        [Config]
        public int TheNewAge;

        [Config("extra/$enum")]
        public AttrEnum MyEnumField;

        [Config("extra/$when")]
        public DateTime When { get; set; }

        [Config("extra/fuzzy")]
        public bool? Fuzzy { get; set; }

        [Config("extra/jazzy")]
        public bool? Jazzy { get; set; }


        [Config("extra/$none1", 155)]
        public int NoneInt { get; set; }

        [Config("extra/$none2", "This is default")]
        public string NoneString { get; set; }

        [Config("extra/$none3", 123.45)]
        public double NoneDouble { get; set; }

        [Config]
        public byte[] Bytes;

        [Config("extra/options")]
        public IConfigSectionNode OptionsProp { get; set; }

        [Config("extra/options")]
        public IConfigSectionNode OptionsField;

    }

}
