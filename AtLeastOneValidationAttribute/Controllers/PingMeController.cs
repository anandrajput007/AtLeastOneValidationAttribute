using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtLeastOneValidationAttribute.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingMeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "You are connected...";
        }
    }
}