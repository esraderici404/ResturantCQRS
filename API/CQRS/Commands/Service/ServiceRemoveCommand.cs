using MediatR;

namespace API.CQRS.Commands.Service
{
    public class ServiceRemoveCommand : IRequest
    {
        public ServiceRemoveCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
