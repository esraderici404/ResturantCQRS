using API.CQRS.Queries.Service;
using API.CQRS.Results.Service;
using Cqrs_dal.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace API.CQRS.Handlers.Service
{
    public class ListServiceQueryHandler : IRequestHandler<ListServiceQuery, List<ServiceResult>>
    {
        private readonly ResutrantContext context;

        public ListServiceQueryHandler(ResutrantContext context)
        {
            this.context = context;
        }

        public async Task<List<ServiceResult>> Handle(ListServiceQuery request, CancellationToken cancellationToken)
        {
            return await context.Services.Select(x => new ServiceResult
            {
                ServiceDescription = x.ServiceDescription,
                ServiceIcon = x.ServiceIcon,
                ServiceID = x.ServiceID,
                ServiceName = x.ServiceName
            }).ToListAsync();
        }
    }
}
