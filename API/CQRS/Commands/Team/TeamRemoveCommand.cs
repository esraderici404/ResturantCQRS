using MediatR;

namespace API.CQRS.Commands.Team
{
    public class TeamRemoveCommand : IRequest
    {
        public TeamRemoveCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
