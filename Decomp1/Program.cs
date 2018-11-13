using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Decomp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FooAsync().Wait();

            Console.WriteLine("\nPress any key to continue....");
            Console.ReadKey();
        }

        public static async Task FooAsync()
        {
            M1();
            PrintCurrentThread("Before async part");
            await BarAsync();
            PrintCurrentThread("After async part");
            M2();
        }

        public static void M1()
        {
            
        }

        public static void M2()
        {

        }

        public static async Task BarAsync()
        {
            await Task.Delay(2000);
        }


        private static void PrintCurrentThread(string methodName)
        {
            var currentThreadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"{methodName} - was called in Thread: {Thread.CurrentThread.ManagedThreadId}");
        }
    }


    internal class FooAsync : IAsyncStateMachine
    {
        public AsyncTaskMethodBuilder _builder;
        public object _this;
        public int _state;
        public void MoveNext()
        {
            try
            {
                switch (_state)
                {
                    case -1:
                        Program.M1();
                        var task = Program.BarAsync();
                        var awaiter = task.GetAwaiter();

                        //Action postback = () =>
                        //{
                        //    awaiter.GetResult();
                        //    Program.M2();
                        //};

                        SendOrPostCallback postback = (state) =>
                        {
                            awaiter.GetResult();
                            Program.M2();
                        };

                        if (awaiter.IsCompleted)
                        {
                            postback(_state);
                        }
                        else
                        {
                            var context = SynchronizationContext.Current;
                            if(context == null)
                            {
                                context = new SynchronizationContext();
                            }
                            var contextCopy = context.CreateCopy();
                            awaiter.OnCompleted(() => contextCopy.Post(postback, null));
                        }

                    case 0: 




                }
            }
            catch (Exception ex)
            {
                _builder.SetException(ex);
                return;
            }
            _builder.SetResult();
        }

        public void SetStateMachine(IAsyncStateMachine stateMachine)
        {
            throw new NotImplementedException();
        }
    }
}
