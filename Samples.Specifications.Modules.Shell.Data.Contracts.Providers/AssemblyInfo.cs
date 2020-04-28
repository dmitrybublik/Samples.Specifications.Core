using System.Reflection;

namespace Samples.Specifications.Modules.Shell.Data.Contracts.Providers
{
    public static class AssemblyInfo
    {
        public static string AssemblyName { get; } = $"{Assembly.GetExecutingAssembly().GetName().Name}.dll";
    }
}