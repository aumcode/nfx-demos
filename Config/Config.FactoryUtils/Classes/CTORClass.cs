using System;
using NFX.Environment;

namespace Config.FactoryUtils.Classes
{
    public class CTORClass : IConfigurable
    {
        public CTORClass(int a, int b) { A = a; B = b; }
        public CTORClass(DateTime dt) { A = dt.Year; B = dt.Month; }
        public readonly int A; public readonly int B;

        public void Configure(IConfigSectionNode node)
        {
            ConfigAttribute.Apply(this, node);
        }
    }
}
