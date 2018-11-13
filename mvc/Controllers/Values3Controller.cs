using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Razor.Text;
using mvc.Services;

namespace mvc.Controllers
{
    public class Values3Controller : ApiController
    {
        //public async Task<int> Get()
        //{
        //    return await SomeMethodAsync();
        //}
   
        //public Task<int> Get()
        //{
        //    try
        //    {
        //        return SomeMethodAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine("Catch exception!");
        //        return Task.FromResult(-1);
        //    }
        
        //}

        public async Task<byte[]> Get()
        {
            var res = BadUsingAsync();

            GC.Collect();

            return await res;
        }

        private Task<byte[]> BadUsingAsync()
        {
            using (var client = new HttpClient())
            {
                return client.GetByteArrayAsync("https://www.onliner.by/");
            }

        }

        private async Task<int> SomeMethodAsync()
        {
            await Task.Delay(15000).ConfigureAwait(false);
            //throw new MyException("bla bla");
            return 100500;
        }


        private async void DoSomeWorkAsync()
        {
            await Task.Delay(1000);
            throw new MyException("bla bla");
        }
    }
}