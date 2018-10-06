using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Itsomax.Data.Infrastructure
{
    public interface IModuleInitializer

    {
        void ConfigureServices(IServiceCollection serviceCollection);
        void Configure(IApplicationBuilder app, IHostingEnvironment env);
    }
}