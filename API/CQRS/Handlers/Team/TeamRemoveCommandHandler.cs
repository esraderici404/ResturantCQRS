using API.CQRS.Commands.Team;
using API.CQRS.Commands.testimonial;
using Cqrs_dal.Context;
using MediatR;

namespace API.CQRS.Handlers.Team
{
    public class TeamRemoveCommandHandler : IRequestHandler<TeamRemoveCommand>
    {
        private readonly ResutrantContext context;

        public TeamRemoveCommandHandler(ResutrantContext context)
        {
            this.context = context;
        }

        public async Task Handle(TeamRemoveCommand request, CancellationToken cancellationToken)
        {
            var team = await context.Teams.FindAsync(request.Id);
            if (team != null)
            {
                context.Teams.Remove(team);
                await context.SaveChangesAsync();
            }


        }
    }
}
