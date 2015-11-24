using Glue.Contracts.Services;

namespace Glue.Server.Services
{
    public class EchoService : IEchoService
    {
        public string Echo(string text)
        {
            return "Your message is: " + text;
        }
    }
}
