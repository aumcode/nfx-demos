using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Glue.Contracts.Services;
using NFX.Security;

namespace Glue.Server.Services
{
    public class SecureService : ISecureService
    {
        public string Echo(string message)
        {
            return "Secure service echo: " + message;
        }

        [AdHocPermission("gov", "executive", AccessLevel.VIEW)]
        public string PresidentEcho(string message)
        {
            return "President secure echo: " + message;
        }
    }
}
