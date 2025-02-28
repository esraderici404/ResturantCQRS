
using Cqrs_dal.Context;
using Cqrs_dal.CQRS.Commands;
using Cqrs_dal.Dal;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cqrs_dal.CQRS.Handlers.food
{
    public class CreateFoodCommandHandler : IRequestHandler<FoodCreateCommand>
    {

        private readonly ResutrantContext context;

        public CreateFoodCommandHandler(ResutrantContext context)
        {
            this.context = context;
        }

        public async Task Handle(FoodCreateCommand request, CancellationToken cancellationToken)
        {
            context.Foods.Add(new Food
            {
                FoodPrice = request.FoodPrice,
                FoodDescription = request.FoodDescription,
                FoodName = request.FoodName
            });
          await  context.SaveChangesAsync();
        }
    }
}
