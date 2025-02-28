using API.CQRS.Commands.Service;
using API.CQRS.Results.Service;
using Cqrs_dal.Context;
using MediatR;

namespace API.CQRS.Handlers.Service
{
    public class ServiceUpdateCommandHandler : IRequestHandler<ServiceUpdateCommand, ServiceUpdate>
    {
        private readonly ResutrantContext context;

        public ServiceUpdateCommandHandler(ResutrantContext context)
        {
            this.context = context;
        }

        public async Task<ServiceUpdate> Handle(ServiceUpdateCommand request, CancellationToken cancellationToken)
        {
            var values = await context.Services.FindAsync(request.ServiceID);

            if (values == null)
            {

                return null;
            }


            values.ServiceDescription = request.ServiceDescription;
            values.ServiceName = request.ServiceName;
            values.ServiceIcon = request.ServiceIcon;
            values.ServiceID= request.ServiceID;

            await context.SaveChangesAsync();

            var result = new ServiceUpdate
            {
                ServiceDescription = request.ServiceDescription,
                ServiceIcon = request.ServiceIcon,
                ServiceName = request.ServiceName,
                ServiceID = request.ServiceID
            };

            return result;
        }
    }
}
