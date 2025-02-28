using API.CQRS.Queries.Service;
using API.CQRS.Results.Service;
using Cqrs_dal.Context;
using MediatR;

namespace API.CQRS.Handlers.Service
{
    public class GetServiceByIDQueryHandler : IRequestHandler<GetServiceByIDQuery, ServiceByIDResult>
    {
        private readonly ResutrantContext context;

        public GetServiceByIDQueryHandler(ResutrantContext context)
        {
            this.context = context;
        }

        public async Task<ServiceByIDResult> Handle(GetServiceByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await context.Services.FindAsync(request.Id);

            return new ServiceByIDResult
            {
                ServiceDescription = values.ServiceDescription,
                ServiceIcon = values.ServiceIcon,
                ServiceID = values.ServiceID,
                ServiceName = values.ServiceName
            };

            
        }
    }
}
