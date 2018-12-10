using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;

namespace Itsomax.Data.Infrastructure
{
    public class SequentialMediator : Mediator
    {
        public SequentialMediator(SingleInstanceFactory singleInstanceFactory, MultiInstanceFactory multiInstanceFactory) 
            : base(singleInstanceFactory, multiInstanceFactory)
        {
        }

        protected override async Task PublishCore(IEnumerable<Task> allHandlers)
        {
            foreach (var handler in allHandlers)
            {
                await handler;
            }
        }
    }
}
