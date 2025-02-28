using API.CQRS.Results.Service;
using MediatR;

namespace API.CQRS.Commands.Service
{
    public class ServiceUpdateCommand : IRequest<ServiceUpdate>
    {
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }
        public string? ServiceIcon { get; set; }
    }
}
