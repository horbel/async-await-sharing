using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace Async_await_controllers.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet]
        public string Get()
        {
            //var a = HttpContext;
            Thread.Sleep(1000);
            return "value";
        }

        [HttpGet("async")]
        public async Task<string> GetAsync()
        {
            await Task.Delay(1000);
            return "value async";
        }
    }
}
