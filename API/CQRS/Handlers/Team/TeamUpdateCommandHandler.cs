using API.CQRS.Commands.Team;
using API.CQRS.Commands.testimonial;
using API.CQRS.Results.Team;
using API.CQRS.Results.Testimonial;
using Cqrs_dal.Context;
using MediatR;

namespace API.CQRS.Handlers.Team
{
    public class TeamUpdateCommandHandler : IRequestHandler<TeamUpdateCommand, TeamUpdate>
    {

        private readonly ResutrantContext context;

        public TeamUpdateCommandHandler(ResutrantContext context)
        {
            this.context = context;
        }

        public async Task<TeamUpdate> Handle(TeamUpdateCommand request, CancellationToken cancellationToken)
        {
            var values = await context.Teams.FindAsync(request.TeamID);
            if (values == null)
            {
                
                return null; 
            }

            values.TeamDescription = request.TeamDescription;
            
            values.TeamNameSurname = request.TeamNameSurname;
            values.TeamPhoto = request.TeamPhoto;

            await context.SaveChangesAsync();

            var result = new TeamUpdate
            {
                TeamPhoto = request.TeamPhoto,
                TeamNameSurname = request.TeamNameSurname,
                TeamDescription = request.TeamDescription,
                TeamID = request.TeamID
            };

            return result;

        }
    }
}
