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
        public async Task<List<ROrgType>> GetOrgTypeList()
        {
            var rr = await Mediator.Send(new List.Query());
            return rr;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ROrgType>> GetOrgTypeById(Guid id)
        {
            // var rr = await _context.ROrgType.FindAsync(id);
            // if (rr == null) return await _context.ROrgType.FirstOrDefaultAsync();
            return await Mediator.Send(new Details.Query { Id = id });
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrgType(ROrgType rOrgType)
        {
            return Ok(await Mediator.Send(new Create.Command { ROrgType = rOrgType }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditOrgType(Guid id, ROrgType rOrgType)
        {
            rOrgType.Id = id;
            return Ok(await Mediator.Send(new Edit.Command { ROrgType = rOrgType }));
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrgType(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command { Id = id }));
        }

    }
}