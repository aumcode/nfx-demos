using NFX.Glue;

namespace Glue.Contracts.Services
{
    [Glued]      
    [LifeCycle(ServerInstanceMode.Stateful, 600000)]
    public interface IStatefulService
    {    
        [Constructor]
        void Init();

        void Add(int value);

        int GetValue();

        [Destructor]
        void Done();
    }
}
