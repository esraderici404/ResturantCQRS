using API.CQRS.Results.Team;
using API.CQRS.Results.Testimonial;
using MediatR;

namespace API.CQRS.Queries.Team
{
    public class ListTeamQuery : IRequest<List<TeamResult>>
    {
    }
}
