using API.CQRS.Commands.Team;
using API.CQRS.Commands.testimonial;
using Cqrs_dal.Context;
using MediatR;

namespace API.CQRS.Handlers.Team
{
    public class TeamCreateCommandHandler : IRequestHandler<TeamCreateCommand>
    {
        private readonly ResutrantContext context;

        public TeamCreateCommandHandler(ResutrantContext context)
        {
            this.context = context;
        }

        public async Task Handle(TeamCreateCommand request, CancellationToken cancellationToken)
        {
            context.Teams.Add(new Dal.Team
            {
                TeamDescription = request.TeamDescription,
                TeamNameSurname = request.TeamNameSurname,
                TeamPhoto = request.TeamPhoto
            });
            await context.SaveChangesAsync();
        }
    }
}
