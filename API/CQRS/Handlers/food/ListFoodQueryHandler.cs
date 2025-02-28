using Cqrs_dal.CQRS.Queries.food;
using Cqrs_dal.CQRS.Results.Food;
using Cqrs_dal.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cqrs_dal.CQRS.Handlers.food
{
    public class ListFoodQueryHandler : IRequestHandler<ListFoodQueryRequest, List<FoodResult>>
    {
        private readonly ResutrantContext context;

        public ListFoodQueryHandler(ResutrantContext context)
        {
            this.context = context;
        }

        public async Task<List<FoodResult>> Handle(ListFoodQueryRequest request, CancellationToken cancellationToken)
        {
            return await context.Foods.Select(x => new FoodResult
            {
                FoodID = x.FoodID,
                FoodName = x.FoodName,
                FoodDescription = x.FoodDescription,
                FoodPrice = x.FoodPrice
            }).ToListAsync();
        }
    }
}
