using NFX.Environment;

namespace Config.NavigationAndEvaluation
{
    /// <summary>
    /// Class to replace default environment variables resolver.
    /// </summary>
    class VarsResolver : IEnvironmentVariableResolver
    {
        public string ResolveEnvironmentVariable(string name)
        {
            if (name == "A") return "1";
            if (name == "B") return "2";
            if (name == "C") return "08/22/2012 2:03PM";
            return null;
        }
    }
}
