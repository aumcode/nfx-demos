using NFX.Environment;

namespace Config.Attributes.Classes
{
    [Config("AttrClassExtended2/data")]
    public class AttrClassExtended2 : AttrClass
    {
        //notice no attributes on this level, they will get inherited here
    }
}
