using NFX.Glue;

namespace Glue.Contracts.Services
{
    [Glued]
    public interface IHighLoadService
    {
        /// <summary>
        /// Does not generate call receipt (one-way call)
        /// </summary>
        [OneWay]
        void Ping1();

        /// <summary>
        /// Generates call receipt (two-way call)
        /// </summary>
        void Ping2();
    }
}
