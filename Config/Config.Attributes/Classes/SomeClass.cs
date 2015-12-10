using System;
using System.Text;
using NFX.Environment;

namespace Config.Attributes.Classes
{
    public enum SomeEnum { A, B, C, D }

    [Config("SomeClass/data")]
    public class SomeClass
    {
        [Config("$pvt-int")]
        private int m_PrivateInt;

        [Config("$prot-name")]
        protected string m_ProtectedName;

        [Config("$pub-int")]
        public int PublicInt { get; set; }

        [Config("$pub-format|$pub-def-format")]
        public string Format { get; set; }

        [Config("$age1")]
        public int Age1 { get; set; }

        [Config]
        public int Age2 { get; set; }

        [Config]
        public int AgeWithHyphens { get; set; }

        [Config("extra/$enum")]
        public SomeEnum SomeEnumField { get; set; }

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

        [Config]
        public byte[] Bytes;

        [Config("extra/options")]
        public IConfigSectionNode OptionsProperty { get; set; }

        public int GetPrivateInt()
        {
            return m_PrivateInt;
        }

        public string GetProtectedName()
        {
            return m_ProtectedName;
        }


        public override string ToString()
        {
            var res = new StringBuilder();
            res.AppendLine("  GetPrivateInt() = " + GetPrivateInt());
            res.AppendLine("  GetProtectedName() = " + (GetProtectedName() ?? "null"));
            res.AppendLine("  PublicInt = " + PublicInt);
            res.AppendLine("  Format = " + Format);
            res.AppendLine("  Age1 = " + Age1);
            res.AppendLine("  Age2 = " + Age2);
            res.AppendLine("  AgeWithHyphens = " + AgeWithHyphens);
            res.AppendLine("  SomeEnumField = " + SomeEnumField);
            res.AppendLine("  When = " + When.ToShortDateString());
            res.AppendLine("  Fuzzy = " + Fuzzy);
            res.AppendLine("  Jazzy.HasValue = " + Jazzy.HasValue);
            res.AppendLine("  NoneInt = " + NoneInt);
            res.AppendLine("  NoneString = " + NoneString);
            res.AppendLine("  Bytes = " + BytesToString());
            res.AppendLine("  OptionsProperty[\"hello\"].Value = " + OptionsProperty["hello"].Value);
            res.AppendLine("  OptionsProperty[\"hello\"].AttrByName(\"a\").ValueAsInt() = " + OptionsProperty["hello"].AttrByName("a").ValueAsInt());
            return res.ToString();
        }

        private string BytesToString()
        {
            if (Bytes == null)
                return "null";
            var res = new StringBuilder("[");
            var len = Bytes.Length-1;
            for (var i = 0; i < len; i++)
            {
                res.Append(string.Format("{0:X}", Bytes[i]) + ", ");
            }
            res.Append(string.Format("{0:X}", Bytes[len]) + "]");
            return res.ToString();
        }
    }
}
