using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Itsomax.Data.Infrastructure
{
    public class ModuleConfigurationManager : IModuleConfigurationManager
    {
        public static readonly string ModulesFilename = "modules.json";

        public IEnumerable<ModuleInfo> GetModules()
        {
            var modulesPath = Path.Combine(GlobalConfiguration.ContentRootPath, ModulesFilename);
            using (var reader = new StreamReader(modulesPath))
            {
                string content = reader.ReadToEnd();
                dynamic modulesData = JsonConvert.DeserializeObject(content);
                foreach (dynamic module in modulesData)
                {
                    yield return new ModuleInfo
                    {
                        Id = module.id,
                        Version = Version.Parse(module.version.ToString())
                    };
                }
            }
        }
    }
}