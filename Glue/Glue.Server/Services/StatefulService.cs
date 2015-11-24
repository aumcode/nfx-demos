using System;
using Glue.Contracts.Services;

namespace Glue.Server.Services
{
    public class StatefulService : IStatefulService
    {
        private int m_State;
           
        public void Init()
        {
        }

        public void Add(int value)
        {
            m_State += value;
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
