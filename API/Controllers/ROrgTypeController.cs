using Application.OrgType;
using Domain.R;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class OrgTypeController : BaseApiController
    {
        // private readonly IMediator _mediator;
        // public OrgTypeController(IMediator mediator)
        // {
        //     _mediator    = mediator;
        // }

        // [HttpGet(Name = "GetWeatherForecast")]

        [HttpGet]
        public async Task<IActionResult> GetOrgTypeList()
        {
            return HandleResult(await Mediator.Send(new List.Query()));
            // var rr = await Mediator.Send(new List.Query());
            // return rr;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ROrgType>> GetOrgTypeById(Guid id)
        {
            // var rr = await _context.ROrgType.FindAsync(id);
            // if (rr == null) return await _context.ROrgType.FirstOrDefaultAsync();
            // var ret = await Mediator.Send(new Details.Query { Id = id });
            return HandleResult(await Mediator.Send(new Details.Query { Id = id }));
            // if (ret.IsSuccess && ret.Value != null) return Ok(ret.Value);
            // if (ret.IsSuccess && ret.Value == null) return NotFound();
            // return BadRequest(ret.Error);
            // var ret = await Mediator.Send(new Details.Query { Id = id });
            // if (ret == null) return NotFound();
            // return ret;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrgType(ROrgType rOrgType)
        {
            return HandleResult(await Mediator.Send(new Create.Command { ROrgType = rOrgType }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditOrgType(Guid id, ROrgType rOrgType)
        {
            rOrgType.Id = id;
            return HandleResult(await Mediator.Send(new Edit.Command { ROrgType = rOrgType }));
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrgType(Guid id)
        {
            return HandleResult(await Mediator.Send(new Delete.Command { Id = id }));
        }

    }
}