using API.CQRS.Results.Team;
using MediatR;

namespace API.CQRS.Commands.Team
{
    public class TeamUpdateCommand : IRequest<TeamUpdate>
    {
        public int TeamID { get; set; }
        public string TeamNameSurname { get; set; }
        public string TeamDescription { get; set; }

        public string? TeamPhoto { get; set; }
    }
}
