using API.CQRS.Commands;
using API.CQRS.Commands.testimonial;
using API.CQRS.Queries.Testimonial;
using Cqrs_dal.CQRS.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TestimonialController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult>TestimonialList()
        {
            var values = await _mediator.Send(new ListTestimonialQuery());
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(TestimonialCreateCommand testimonialCreateCommand)
        {
            await _mediator.Send(testimonialCreateCommand);
            return Ok("Başarıyla Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            await _mediator.Send(new TestimonialRemoveCommand(id));
            return Ok("Başarıyla Silindi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestimonialyById(int id)
        {
            var value = await _mediator.Send(new GetTestimonialByIDQuery(id));
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTestimonial(TestimonialUpdateCommand command)
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
