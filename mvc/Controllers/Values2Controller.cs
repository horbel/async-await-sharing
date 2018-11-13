using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace mvc.Controllers
{
    public class Values2Controller : ApiController
    {
        [HttpGet]
        public int Get()
        {
            var res = SomeMethodAsync().Result;
            return res;
        }

        private async Task<int> SomeMethodAsync()
        {
            await Task.Delay(1000).ConfigureAwait(false);
          
            return 100500;
        }


        private async void DoSomeWorkAsync()
        {
            await Task.Delay(1000);
            throw new MyException("bla bla");
        }
    }

    public class MyException : Exception
    {
        public MyException(string mess) : base(mess)
        {

        }
    }
    //TODO: throw exception. sync and async flows. task/void. result vs awaiter. async in Action  
}
