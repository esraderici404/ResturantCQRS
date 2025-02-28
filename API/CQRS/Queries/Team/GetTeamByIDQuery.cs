using API.CQRS.Results.Team;
using MediatR;

namespace API.CQRS.Queries.Team
{
    public class GetTeamByIDQuery : IRequest<TeamByIDResult>
    {
        public GetTeamByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
