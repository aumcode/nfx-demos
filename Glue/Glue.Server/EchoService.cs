using Glue.Contracts.Services;

namespace Glue.Server
{
    public class EchoService : IEchoService
    {
        public string Echo(string text)
        {
            return "Your message is: " + text;
        }
    }
}
