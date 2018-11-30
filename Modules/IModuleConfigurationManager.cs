using System.Collections.Generic;

namespace Itsomax.Data.Infrastructure
{
    public interface IModuleConfigurationManager
    {
        IEnumerable<ModuleInfo> GetModules();
    }
}