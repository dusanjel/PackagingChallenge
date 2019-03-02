using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PackagingChallenge.Business.ServiceModels;

namespace PackagingChallenge.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PackController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<bool> Ping()
        {
            return true;
        }

        [HttpPost]
        public ActionResult<string> Post([FromBody] PackageServiceModel value)
        {
            return "";
        }         
    }
}
