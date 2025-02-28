
using Cqrs_dal.Context;
using Cqrs_dal.CQRS.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cqrs_dal.CQRS.Handlers.food
{
    public class FoodRemoveCommandHandler : IRequestHandler<FoodRemoveCommand>
    {
        private readonly ResutrantContext context;

        public FoodRemoveCommandHandler(ResutrantContext context)
        {
            this.context = context;
        }

        public async Task Handle(FoodRemoveCommand request, CancellationToken cancellationToken)
        {
            var values = await context.Foods.FindAsync(request.Id);
            if (values == null)
            {
                context.Foods.Remove(values);
                await context.SaveChangesAsync();
            }
           
        }
    }
}
