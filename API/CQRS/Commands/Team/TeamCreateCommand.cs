using MediatR;

namespace API.CQRS.Commands.Team
{
    public class TeamCreateCommand : IRequest
    {
        public string TeamNameSurname { get; set; }
        public string TeamDescription { get; set; }

        public string? TeamPhoto { get; set; }
    }
}
