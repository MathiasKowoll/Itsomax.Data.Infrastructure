using System;
using System.Linq;
using System.Reflection;
namespace Itsomax.Data.Infrastructure
{
    public class ModuleInfo
    {
       
        public string Id { get; set; }

        public string Name { get; set; }

        public bool IsBundledWithHost { get; set; }

        public Version Version { get; set; }

        public Assembly Assembly { get; set; }
    }
}