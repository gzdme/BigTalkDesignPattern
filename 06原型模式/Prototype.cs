using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 原型模式
{
    // 原型类
    abstract class Prototype
    {
        private string _id;
        public Prototype(string id)
        {
            this._id = id;
        }

        public string Id
        {
            get { return _id; }
        }

        public abstract Prototype Clone();
    }
    // 具体原型类
    class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string id) : base(id)
        {

        }
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
    // 客户端代码实现
    class Client
    {
        //static void Main(string[] args)
        //{
        //    ConcretePrototype1 p1 = new ConcretePrototype1("I");
        //    ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
        //    Console.WriteLine("Cloned: {0}", c1.Id);

        //    Console.Read();
        //}
    }
}
