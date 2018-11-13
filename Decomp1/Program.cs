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
            await BarAsync();
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
    }
}
