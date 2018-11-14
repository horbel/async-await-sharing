using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace mvc.Controllers
{
    public class ValuesController : ApiController
    {
        //*/
        [HttpGet]
        public async Task<int> Get()
        {
            Debug.WriteLine($"Get before await: {Thread.CurrentThread.ManagedThreadId}");
            var currentContextBefore = HttpContext.Current.Server;

            var res = await SomeMethodAsync();

            var currentContextAfter = HttpContext.Current.Server;
            Debug.WriteLine($"Get after await: {Thread.CurrentThread.ManagedThreadId}");

            return res;
        }

        /*/

        [HttpGet]
        public int Get()
        {
            var res = SomeMethodAsync().Result;
            return res;
        }

        //*/

        private async Task<int> SomeMethodAsync()
        {
            Debug.WriteLine($"SomeMethodAsync before await: {Thread.CurrentThread.ManagedThreadId}");
            await Task.Delay(1000);
            Debug.WriteLine($"SomeMethodAsync after await: {Thread.CurrentThread.ManagedThreadId}");
            return 100500;
        } 
    }
}
