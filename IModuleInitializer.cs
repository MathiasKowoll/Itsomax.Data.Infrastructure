using Microsoft.Extensions.DependencyInjection;

namespace Itsomax.Data.Infrastructure
{
    public interface IModuleInitializer
    {
        void Init(IServiceCollection serviceCollection);
    }
}