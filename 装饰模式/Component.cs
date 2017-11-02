using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    // 构件类
    abstract class Component
    {
        public abstract void Operation();
    }
    // 具体构件类
    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("具体对象的操作");
        }
    }
    // 装饰器类
    abstract class Decorator : Component
    {
        protected Component component;
        public void SetComponet(Component component)
        {
            this.component = component;
        }
        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }
    // 具体装饰器A
    class ConcreteDecoratorA : Decorator
    {
        private string addedState;
        public override void Operation()
        {
            base.Operation();
            addedState = "New State";
            Console.WriteLine("具体装饰对象A的操作");
        }
    }
    // 具体装饰器B
    class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();  // 本类的操作
            Console.WriteLine("具体装饰对象B的操作");
        }
        private void AddedBehavior()
        {

        }
    }

    // 装饰模式客户端
    class Client
    {
        //static void Main(string[] args)
        //{
        //    ConcreteComponent c = new ConcreteComponent();
        //    ConcreteDecoratorA d1 = new ConcreteDecoratorA();
        //    ConcreteDecoratorB d2 = new ConcreteDecoratorB();

        //    d1.SetComponet(c);
        //    d2.SetComponet(d1);
        //    d2.Operation();

        //    Console.Read();
        //}
    }
}
