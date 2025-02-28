using MediatR;

namespace API.CQRS.Commands.Service
{
    public class ServiceCreateCommand : IRequest
    {
       
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }
        public string? ServiceIcon { get; set; }
    }
}
