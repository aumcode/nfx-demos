using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Config.LittleComplicated
{
    class MyVars : IEnvironmentVariableResolver
    {

        public string ResolveEnvironmentVariable(string name)
        {
            if (name == "A") return "1";
            if (name == "B") return "2";
            if (name == "C") return "01/18/1901 2:03PM";
            return null;
        }
    }
}
