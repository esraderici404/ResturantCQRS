using Cqrs_dal.CQRS.Results.Food;
using MediatR;

namespace API.CQRS.Commands
{
    public class UpdateFoodCommand : IRequest<FoodUpdate>
    {
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public string FoodDescription { get; set; }
        public decimal FoodPrice { get; set; }
    }
}
