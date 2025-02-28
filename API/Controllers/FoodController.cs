using API.CQRS.Commands;

using Cqrs_dal.CQRS.Commands;
using Cqrs_dal.CQRS.Queries.food;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FoodController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> FootList()
        {
            var values = await _mediator.Send(new ListFoodQueryRequest());
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateFood(FoodCreateCommand foodCreateCommand)
        {
            await _mediator.Send(foodCreateCommand);
            return Ok("Başarıyla Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteFood(int id)
        {
            await _mediator.Send(new FoodRemoveCommand(id));
            return Ok("Başarıyla Silindi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFoodyById(int id)
        {
            var value = await _mediator.Send(new GetFoodtByIDQuery(id));
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateFood( UpdateFoodCommand command)
        {       
            var result = await _mediator.Send(command);

            if (result != null)
            {
                return Ok(result);
                
            }
            else
            {
                return NotFound(); 
            }
        }

    }
}
