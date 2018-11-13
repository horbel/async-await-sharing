using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Reflection;
using System.Diagnostics;

namespace async_await_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodExecutorAsync().Wait();

            Console.ReadKey();
        }

        public static async Task MethodExecutorAsync()
        {
            var methodName = "MethodExecutorAsync";

            PrintCurrentThread(methodName);
            await MyMethodAsync();
            PrintCurrentThread(methodName);
        }

        public static async Task MyMethodAsync()
        {
            var methodName = "MyMethodAsync";
            PrintCurrentThread(methodName);

            Console.WriteLine("Start executing async work....");
            await Task.Delay(5000).ConfigureAwait(true);
            Console.WriteLine("Finish executing async work!!");

            PrintCurrentThread(methodName);
        }

        private static void PrintCurrentThread(string methodName)
        {
            var currentThreadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"{methodName} - was called in Thread: {Thread.CurrentThread.ManagedThreadId}");
        } 
    }
}