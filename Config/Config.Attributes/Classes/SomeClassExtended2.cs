using NFX.Environment;

namespace Config.Attributes.Classes
{
    [Config("SomeClassExtended2/data")]
    public class SomeClassExtended2 : SomeClass
    {
        //notice no attributes on this level, they will get inherited here
    }
}
