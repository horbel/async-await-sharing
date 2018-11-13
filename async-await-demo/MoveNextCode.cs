//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace async_await_demo
//{
//    class MoveNextCode
//    {

//        public static async Task<Int32> MethodTaskAsync()
//        {
//            Int32 one = 33;
//            await Task.Delay(1000);
//            return one;
//        }

//        private int one;
//        private int state = -1;
//        private AsyncTaskMethodBuilder asyncTaskMethodBuilder;
//        public void MoveNext()
//        {
//            switch (this.state)
//        {
//            case -1:
//                this.one = 33;
//                var task = Task.Delay(1000);
//                var awaiter = task.GetAwaiter(); // стоит отметить, что это локальные переменные метода, а не самого типа (исходя из IL-кода)

//                    var a = MethodTaskAsync;
//                if (!awaiter.IsCompleted)
//                {
//                    this.state = 0;
//                    this.u__awaiter = awaiter; //u__awaiter это тип TaskAwaiter
//                    t_builder.AwaitUnsafeOnCompleted(ref this.u_awaiter, ref MethodTaskAsync d);
//                    return;
//                }

//            case 0:
//                var awaiter = this.u_awaiter;
//                this.u_awaiter = new System.Runtime.CompilerServices.TaskAwaiter();
//                this.state = -1;

//                awaiter.GetResult();
//                awaiter = new System.Runtime.CompilerServices.TaskAwaiter();
//                var one = this.< one > 5_1;

//                this.state = -2;
//                this.t_builder.SetResult(one);
//            }
//        }
//    }
//}
