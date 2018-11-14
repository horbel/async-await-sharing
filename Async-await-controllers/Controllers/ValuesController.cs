using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Thread.Sleep(1000);
            return "value";
        }

        [HttpGet("async")]
        public async Task<string> GetAsync()
        {
            Debug.WriteLine($"GetAsync before await: {Thread.CurrentThread.ManagedThreadId}");
            await SomeMethodAsync();
            Debug.WriteLine($"GetAsync after await: {Thread.CurrentThread.ManagedThreadId}");
            //await Task.Delay(1000);
            return "value async";
        }

        private async Task SomeMethodAsync()
        {
            Debug.WriteLine($"SomeMethodAsync before await: {Thread.CurrentThread.ManagedThreadId}");
            await Task.Delay(1000);
            Debug.WriteLine($"SomeMethodAsync after await: {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
