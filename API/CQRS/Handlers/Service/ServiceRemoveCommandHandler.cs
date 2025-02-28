using API.CQRS.Commands.Service;
using Cqrs_dal.Context;
using MediatR;

namespace API.CQRS.Handlers.Service
{
    public class ServiceRemoveCommandHandler : IRequestHandler<ServiceRemoveCommand>
    {
        private readonly ResutrantContext context;

        public ServiceRemoveCommandHandler(ResutrantContext context)
        {
            this.context = context;
        }

        public async Task Handle(ServiceRemoveCommand request, CancellationToken cancellationToken)
        {
            var values = await context.Services.FindAsync(request.Id);
            if (values == null)
            {
                context.Services.Remove(values);
                await context.SaveChangesAsync();
            }
          

        }
    }
}
