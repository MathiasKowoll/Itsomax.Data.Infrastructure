using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;

namespace Itsomax.Data.Infrastructure
{
    public class SequentialMediator : Mediator
    {
        public SequentialMediator(ServiceFactory serviceFactory) : base(serviceFactory)
        {
        }
        /*
        protected async override Task PublishCore(IEnumerable<Task> allHandlers)
        {
            foreach(var handler in allHandlers)
            {
                await handler;
            }
        }
        */
    }
}
