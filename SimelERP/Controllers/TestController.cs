using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimelERP.Application.Test.Query.Commands;
using SimelERP.Application.Test.Query.GetTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SimelERP.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TestController : BaseController
    {

        [HttpGet]
        public async Task<ActionResult<TestViewModel>> Get(int id)
        {
            return Ok(await Mediator.Send(new GetTestQuery { Id = id }));
        }


      
       [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update(int id, [FromBody]UpdateTestCommand command)
        {
            command.TestERPId = id;
            await Mediator.Send(command);

            return NoContent();
        }
    }
}
