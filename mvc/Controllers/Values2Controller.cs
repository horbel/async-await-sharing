using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Web.Http;

namespace mvc.Controllers
{
    public class Values2Controller : ApiController
    {
        //public int Get()
        //{
        //    var res = 0;
        //    try
        //    {
        //        res = SomeMethodAsync().Result;
        //    }
        //    catch (MyException ex)
        //    {
        //        Debug.WriteLine("ya tebya slovil!");
        //    }

        //    return res;
        //}

        //public int Get()
        //{
        //    var res = 0;
        //    try
        //    {
        //        res = SomeMethodAsync().GetAwaiter().GetResult();
        //    }
        //    catch (MyException ex)
        //    {
        //        Debug.WriteLine("ya tebya slovil!");
        //    }

        //    return res;
        //}

        public int Get()
        {
            var res = 0;
            try
            {
                DoSomeWorkAsync();
            }
            catch (MyException ex)
            {
                Debug.WriteLine("ya tebya slovil!");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ya tebya tochno slovil");
            }

            return res;
        }

        private async Task<int> SomeMethodAsync()
        {
            await Task.Delay(1000).ConfigureAwait(false);
            throw new MyException("bla bla");
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
