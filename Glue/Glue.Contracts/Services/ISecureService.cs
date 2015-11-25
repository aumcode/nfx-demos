using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NFX.Glue;
using NFX.Security;

namespace Glue.Contracts.Services
{
    /// <summary>
    /// Only those users who have superman permission can call the service
    /// </summary>
    [Glued]
    [AuthenticationSupport]
    [AdHocPermission("specialized", "superman", AccessLevel.VIEW)]
    public interface ISecureService
    {
        string Echo(string message);

        /// <summary>
        /// This method can only accessed by superman who is also a president
        /// </summary>
        [AdHocPermission("specialized", "president", AccessLevel.VIEW)]
        string PresidentEcho(string message);
    }
}
