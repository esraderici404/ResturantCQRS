using API.CQRS.Commands.Team;
using API.CQRS.Queries.Team;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TeamController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> TeamList()
        {
            var values = await _mediator.Send(new ListTeamQuery());
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTeam(TeamCreateCommand TeamCreateCommand)
        {
            await _mediator.Send(TeamCreateCommand);
            return Ok("Başarıyla Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteTeam(int id)
        {
            await _mediator.Send(new TeamRemoveCommand(id));
            return Ok("Başarıyla Silindi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTeamyById(int id)
        {
            var value = await _mediator.Send(new GetTeamByIDQuery(id));
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTeam(TeamUpdateCommand command)
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
