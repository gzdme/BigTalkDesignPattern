using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 状态模式
{
    abstract class State
    {
        public abstract void Handle(Context context);
    }
    class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }
    class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
    class Context
    {
        private State _state;

        public Context(State state)
        {
            this._state = state;
        }

        public State State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine("当前状态：" + _state.GetType().Name);
            }
        }
        public void Request()
        {
            this._state.Handle(this);
        }
    }
    // 状态模式的客户端实现
    class Client
    {
        //static void Main(string[] args)
        //{
        //    Context c = new Context(new ConcreteStateA());

        //    c.Request();
        //    c.Request();
        //    c.Request();
        //    c.Request();

        //    Console.Read();
        //}
    }
}
