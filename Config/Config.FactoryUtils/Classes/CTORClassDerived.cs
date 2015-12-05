using System;
using NFX.Environment;

namespace Config.FactoryUtils.Classes
{
    public class CTORClassDerived : CTORClass
    {
        public CTORClassDerived(int a, int b) : base(a, b) { }
        public CTORClassDerived(DateTime dt) : base(dt) { }

        public readonly int C = 155;

        [Config]
        public string Data1 { get; set; }

        [Config]
        public string Data2;
    }
}
