using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Razor;

namespace Itsomax.Data.Infrastructure.Web
{
    public class ModuleViewLocationExpander : IViewLocationExpander
    {
        private const string ModuleKey = "module";

        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            context.Values.TryGetValue(ModuleKey, out string module);


            if (!string.IsNullOrWhiteSpace(module))
            {
                var moduleViewLocations = new[]
                {
                    $"/Modules/{module}/Views/{{1}}/{{0}}.cshtml",
                    $"/Modules/{module}/Views/Shared/{{0}}.cshtml"
                };

                viewLocations = moduleViewLocations.Concat(viewLocations);
            }

            return viewLocations;
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
            var controllerName = context.ActionContext.ActionDescriptor.DisplayName;
            // Get assembly name
            var moduleName = controllerName.Split('(', ')')[1];
            context.Values[ModuleKey] = moduleName;
        }
    }
}