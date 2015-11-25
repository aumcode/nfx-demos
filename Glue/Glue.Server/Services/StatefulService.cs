using System;
using Glue.Contracts.Services;
using NFX.Glue;
using System.Threading;

namespace Glue.Server.Services
{
    /// <summary>
    /// Notice the use of ThreadSafeAttribute which tells the Glue runtime
    /// that this class implements thread-safety internally, so Glue doesn't
    /// need to lock its instance.
    /// </summary>
    [ThreadSafe]
    public class StatefulService : IStatefulService
    {
        private int m_State;
           
        public void Init()
        {
        }

        public void Add(int value)
        {
            // this is our thread-safe addition
            Interlocked.Add(ref m_State, value);
        } 

        public int GetValue()
        {
            return m_State;
        }

        public void Done()
        {
        }
    }
}
