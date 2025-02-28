using API.CQRS.Queries.Team;

using API.CQRS.Results.Team;

using Cqrs_dal.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace API.CQRS.Handlers.Team
{
    public class ListTeamQueryHandler : IRequestHandler<ListTeamQuery, List<TeamResult>>
    {
        private readonly ResutrantContext context;

        public ListTeamQueryHandler(ResutrantContext context)
        {
            this.context = context;
        }

        public async Task<List<TeamResult>> Handle(ListTeamQuery request, CancellationToken cancellationToken)
        {
            return await context.Teams.Select(x => new TeamResult
            {
                TeamID = x.TeamID,
                TeamDescription = x.TeamDescription,
                TeamNameSurname = x.TeamNameSurname,
                TeamPhoto = x.TeamPhoto
            }).ToListAsync();
        }
    }
}
