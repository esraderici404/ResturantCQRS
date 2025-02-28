using API.CQRS.Commands.Service;
using API.CQRS.Queries.Service;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ServiceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ServiceList()
        {
            var values = await _mediator.Send(new ListServiceQuery());
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateService(ServiceCreateCommand ServiceCreateCommand)
        {
            await _mediator.Send(ServiceCreateCommand);
            return Ok("Başarıyla Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteService(int id)
        {
            await _mediator.Send(new ServiceRemoveCommand(id));
            return Ok("Başarıyla Silindi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetServiceyById(int id)
        {
            var value = await _mediator.Send(new GetServiceByIDQuery(id));
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateService(ServiceUpdateCommand command)
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
