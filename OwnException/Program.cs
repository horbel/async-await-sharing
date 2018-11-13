using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DoSomeAction(async () => {
                    await Task.Run(() =>
                    {
                        Console.WriteLine("hi im in action");
                        throw new AsyncException("My ex!");
                    });

                });

                //MethodTaskAsync2();
                //Console.WriteLine();
            }
            catch (AsyncException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



            GC.Collect();
            Console.ReadKey();
        }

        //public static async Task<Int32> MethodTaskAsync()
        //{
        //    Int32 one = 33;
        //    throw new AsyncException("EXCEPTION!!!!");
        //    await Task.Delay(1000);
        //    return one;
        //}


        public static void DoSomeAction(Action action)
        {
            action();
        }
        public static async void MethodTaskAsync2()
        {
            Int32 one = 33;
            await Task.Delay(1000);
            throw new AsyncException("EXCEPTION!!!!");
            //await Task.Delay(1000);
        }
    }

    public class AsyncException : Exception
    {
        public AsyncException(string mes) : base(mes) { }
    }

}
