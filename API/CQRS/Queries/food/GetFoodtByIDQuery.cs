using Cqrs_dal.CQRS.Results.Food;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cqrs_dal.CQRS.Queries.food
{
    public class GetFoodtByIDQuery : IRequest<FoodByIDResult>
    {
        public GetFoodtByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
