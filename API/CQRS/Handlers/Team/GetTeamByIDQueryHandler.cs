using API.CQRS.Queries.Team;
using API.CQRS.Queries.Testimonial;
using API.CQRS.Results.Team;
using API.CQRS.Results.Testimonial;
using Cqrs_dal.Context;
using MediatR;

namespace API.CQRS.Handlers.Team
{
    public class GetTeamByIDQueryHandler : IRequestHandler<GetTeamByIDQuery, TeamByIDResult>
    {
        private readonly ResutrantContext context;

        public GetTeamByIDQueryHandler(ResutrantContext context)
        {
            this.context = context;
        }

        public async Task<TeamByIDResult> Handle(GetTeamByIDQuery request, CancellationToken cancellationToken)
        {
            var team = await context.Teams.FindAsync(request.Id);

            return new TeamByIDResult
            {
                TeamDescription = team.TeamDescription,
                TeamID = team.TeamID,
                TeamNameSurname = team.TeamNameSurname,
                TeamPhoto = team.TeamPhoto
            };
        }
    }
}
