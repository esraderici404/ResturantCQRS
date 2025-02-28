using Cqrs_dal.Context;
using Cqrs_dal.CQRS.Queries.food;
using Cqrs_dal.CQRS.Results.Food;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace API.CQRS.Handlers.food
{
    public class GetFoodtByIDQueryHandler : IRequestHandler<GetFoodtByIDQuery, FoodByIDResult>

    {
        private readonly ResutrantContext context;

        public GetFoodtByIDQueryHandler(ResutrantContext context)
        {
            this.context = context;
        }

        public async Task<FoodByIDResult> Handle(GetFoodtByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await context.Foods.FindAsync(request.Id);
            return new FoodByIDResult
            {
                FoodID = values.FoodID,
                FoodDescription = values.FoodDescription,
               
                FoodName = values.FoodName,
                FoodPrice = values.FoodPrice
            };
           
        }
    }
}
