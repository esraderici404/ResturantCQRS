using API.CQRS.Commands.Service;
using Cqrs_dal.Context;
using MediatR;

namespace API.CQRS.Handlers.Service
{
    public class ServiceCreateCommandHandler : IRequestHandler<ServiceCreateCommand>
    {
        private readonly ResutrantContext context;

        public ServiceCreateCommandHandler(ResutrantContext context)
        {
            this.context = context;
        }

        public async Task Handle(ServiceCreateCommand request, CancellationToken cancellationToken)
        {
            context.Services.Add(new Dal.Service
            {
                ServiceDescription = request.ServiceDescription,
                ServiceIcon = request.ServiceIcon,
                ServiceName = request.ServiceName


            });
           await  context.SaveChangesAsync(); 
        }
    }
}
