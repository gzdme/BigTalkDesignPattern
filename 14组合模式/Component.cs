using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 组合模式
{
    // 抽象类Component，声明所有类共有接口
    abstract class Component
    {
        protected string name;
        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void Display(int depth);
    }
    // 树叶节点Leaf，为共有接口实现行为
    class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Remove(Component component)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }
    }
    // 分支节点Composite，为共有接口实现行为
    class Composite : Component
    {
        private List<Component> children = new List<Component>();
        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            children.Add(component);
        }
        public override void Remove(Component component)
        {
            children.Remove(component);
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
            foreach (Component ct in children)
            {
                ct.Display(depth + 2);
            }
        }
    }
    // 组合模式的客户端代码实现
    class Client
    {
        //static void Main(string[] args)
        //{
        //    Composite root = new Composite("root");
        //    root.Add(new Leaf("Leaf A"));
        //    root.Add(new Leaf("Leaf B"));

        //    Composite comp = new Composite("Composite X");
        //    comp.Add(new Leaf("Leaf XA"));
        //    comp.Add(new Leaf("Leaf XB"));

        //    root.Add(comp);

        //    Composite comp2 = new Composite("Composite Y");
        //    comp2.Add(new Leaf("Leaf XYA"));
        //    comp2.Add(new Leaf("Leaf XYB"));

        //    comp.Add(comp2);

        //    root.Add(new Leaf("Leaf C"));

        //    Leaf leaf = new Leaf("Leaf D");
        //    root.Add(leaf);
        //    root.Remove(leaf);

        //    root.Display(1);

        //    Console.Read();
        //}
    }
}
