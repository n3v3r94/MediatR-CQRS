using MediatR;
using Microsoft.AspNetCore.Mvc;
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
    }
}
