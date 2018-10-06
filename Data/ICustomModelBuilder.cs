using Microsoft.EntityFrameworkCore;

namespace Itsomax.Data.Infrastructure.Data
{
    public interface ICustomModelBuilder
    {
        void Build(ModelBuilder mModelBuilder);
    } 
}   