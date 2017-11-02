using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    // 产品类————由多个部件按一定顺序组成
    class Product
    {
        IList<string> parts = new List<string>();
        public void Add(string part)
        {
            parts.Add(part);
        }
        public void Show()
        {
            System.Windows.MessageBox.Show("\n 产品 创建 ---------");
            foreach (string part in parts)
            {
                System.Windows.MessageBox.Show(part);
            }
        }
    }
    // 抽象建造者类
    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();
    }
    // 具体建造者类1
    class ConcreteBuilder1 : Builder
    {
        private Product product = new Product();
        public override void BuildPartA()
        {
            product.Add("部件A");
        }

        public override void BuildPartB()
        {
            product.Add("部件B");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
    // 具体建造者类2
    class ConcreteBuilder2 : Builder
    {
        private Product product = new Product();
        public override void BuildPartA()
        {
            product.Add("部件X");
        }

        public override void BuildPartB()
        {
            product.Add("部件Y");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
    // 指挥者————按一定顺序指挥建造者创建产品
    class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
    // 建造者模式客户端代码
    class Client
    {
        //static void Main(string[] args)
        //{
        //    Director director = new Director();
        //    Builder builder1 = new ConcreteBuilder1();
        //    Builder builder2 = new ConcreteBuilder2();

        //    director.Construct(builder1);
        //    Product p1 = builder1.GetResult();
        //    p1.Show();

        //    Product p2 = builder2.GetResult();
        //    p2.Show();

        //    Console.Read();
        //}
    }
}
