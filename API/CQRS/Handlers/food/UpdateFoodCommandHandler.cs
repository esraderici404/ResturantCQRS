using API.CQRS.Commands;

using Cqrs_dal.Context;
using Cqrs_dal.CQRS.Results.Food;
using Cqrs_dal.Dal;
using MediatR;

namespace API.CQRS.Handlers.food
{
    public class UpdateFoodCommandHandler : IRequestHandler<UpdateFoodCommand, FoodUpdate>
    {
        private readonly ResutrantContext context;

        public UpdateFoodCommandHandler(ResutrantContext context)
        {
            this.context = context;
        }

        public async Task<FoodUpdate> Handle(UpdateFoodCommand request, CancellationToken cancellationToken)
        {
            var food = await context.Foods.FindAsync(request.FoodID);

            if (food == null)
            {
                throw new Exception("Belirtilen yemek bulunamadı"); // Hata işleme kodu burada
            }

            // İlgili alanları güncelle
            food.FoodDescription = request.FoodDescription;
            food.FoodName = request.FoodName;
            food.FoodPrice = request.FoodPrice;

            await context.SaveChangesAsync(); // Değişiklikleri kaydet

            var result = new FoodUpdate
            {
                FoodID = food.FoodID,
                FoodDescription = food.FoodDescription,
                FoodName = food.FoodName,
                FoodPrice = food.FoodPrice
            };

            return result;

        }
    }
}
