using NFX.Glue;

namespace Glue.Contracts.Services
{
    [Glued]
    public interface IEchoService
    {
        string Echo(string text);
    }
}
