using Application.AppAgama;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [AllowAnonymous]
    public class AgamaController : BaseApiController
    {

        [HttpGet]
        public async Task<IActionResult> GetAgamaList()
        {
            return HandleResult(await Mediator.Send(new List.Query()));
        }

        // [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<Agama>> GetAgamaById(Guid id)
        {
            return HandleResult(await Mediator.Send(new Details.Query { Id = id }));
        }

        [HttpPost]
        public async Task<IActionResult> CreateAgama(Agama agama)
        {
            return HandleResult(await Mediator.Send(new Create.Command { Agama = agama }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditAgama(Guid id, Agama agama)
        {
            agama.Id = id;
            return HandleResult(await Mediator.Send(new Edit.Command { Agama = agama }));
        }

        [HttpDelete("{id}/{timeStamp}")]
        public async Task<IActionResult> DeleteAgama(Guid id, string timeStamp)
        {
            return HandleResult(await Mediator.Send(new Delete.Command { Id = id, TimeStamp = timeStamp }));
        }

    }
}