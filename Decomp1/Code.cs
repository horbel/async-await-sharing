//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace Decomp1
//{
//    internal class FooAsync : IAsyncStateMachine
//    {
//        public AsyncTaskMethodBuilder _builder;
//        public object _this;
//        public int _state;
//        public void MoveNext()
//        {
//            try
//            {
//                switch (_state)
//                {
//                    case -1:
                        
//                }
//            }
//            catch(Exception ex)
//            {
//                _builder.SetException(ex);
//                return;
//            }
//            _builder.SetResult();
//        }

//        public void SetStateMachine(IAsyncStateMachine stateMachine)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
