using System.Collections.Generic;
using NFX.Glue;
using Glue.Contracts.DataContracts;

namespace Glue.Contracts.Services
{
    [Glued]
    [LifeCycle(ServerInstanceMode.Singleton)]
    public interface IPersonService
    {
        void Set(Person person);

        List<Person> FindByName(string pattern); 
    }
}
