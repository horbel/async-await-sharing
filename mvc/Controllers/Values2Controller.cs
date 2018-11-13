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
    public class Values2Controller : ApiController
    {
        /*/
        [HttpGet] 
        public async Task<int> Get()
        {
            Debug.WriteLine($"before await: {Thread.CurrentThread.ManagedThreadId}");

            var currentContextBefore = HttpContext.Current.Server;

            var res = await SomeMethodAsync();

            //var currentContext = HttpContext.Current.Server;
            Debug.WriteLine($"before await: {Thread.CurrentThread.ManagedThreadId}");

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

        private async void DoSomeWorkAsync()
        {
            await Task.Delay(1000).ConfigureAwait(false);

            throw new MyException("alo, mi ypali!!");
        }


    }

    public class MyException : Exception
    {

    }
}
