using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    #region 过程式描述
    //class Person
    //{
    //    private string name;
    //    public Person(string name)
    //    {
    //        this.name = name;
    //    }
    //    public void WearTShirts()
    //    {
    //        Console.WriteLine("大T恤");
    //    }
    //    public void WearBigTrouser()
    //    {
    //        Console.WriteLine("大短裤");
    //    }
    //    public void WearSneakers()
    //    {
    //        Console.WriteLine("破球鞋");
    //    }
    //    public void WearSuit()
    //    {
    //        Console.WriteLine("西装");
    //    }
    //    public void WearTie()
    //    {
    //        Console.WriteLine("领带");
    //    }
    //    public void WearLeatherShoes()
    //    {
    //        Console.WriteLine("皮鞋");
    //    }
    //    public void Show()
    //    {
    //        Console.WriteLine("装扮的{0}", name);
    //    }
    //}
    #endregion

    #region 考虑开放-封闭原则后拆解为Person、Finery及各个服饰类
    //class Person
    //{
    //    private string name;
    //    public Person(string name)
    //    {
    //        this.name = name;
    //    }

    //    public void Show()
    //    {
    //        Console.WriteLine("装扮的{0}", name);
    //    }
    //}
    //abstract class Finery
    //{
    //    public abstract void Show();
    //}
    //class BigTrouser : Finery
    //{
    //    public override void Show()
    //    {
    //        Console.WriteLine("大短裤");
    //    }
    //}
    //class TShirts : Finery
    //{
    //    public override void Show()
    //    {
    //        Console.WriteLine("大T恤");
    //    }
    //}
    //class Sneakers : Finery
    //{
    //    public override void Show()
    //    {
    //        Console.WriteLine("破球鞋");
    //    }
    //}
    //class Suit : Finery
    //{
    //    public override void Show()
    //    {
    //        Console.WriteLine("西装");
    //    }
    //}
    //class Tie : Finery
    //{
    //    public override void Show()
    //    {
    //        Console.WriteLine("领带");
    //    }
    //}
    //class LeatherShoes : Finery
    //{
    //    public override void Show()
    //    {
    //        Console.WriteLine("皮鞋");
    //    }
    //}
    #endregion

    #region 装饰模式修改Finery及各个服饰类
    class Person
    {
        public Person()
        {

        }

        private string name;
        public Person(string name)
        {
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("装扮的{0}", name);
        }
    }
    abstract class Finery : Person
    {
        protected Person component;
        // 打扮
        public void Decorate(Person component)
        {
            this.component = component;
        }
        public override void Show()
        {
            if (component != null)
            {
                component.Show();
            }
        }
    }
    class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.WriteLine("大短裤 ");
            base.Show();
        }
    }
    class TShirts : Finery
    {
        public override void Show()
        {
            Console.WriteLine("大T恤");
            base.Show();
        }
    }
    class Sneakers : Finery
    {
        public override void Show()
        {
            Console.WriteLine("破球鞋");
            base.Show();
        }
    }
    class Suit : Finery
    {
        public override void Show()
        {
            Console.WriteLine("西装");
            base.Show();
        }
    }
    class Tie : Finery
    {
        public override void Show()
        {
            Console.WriteLine("领带");
            base.Show();
        }
    }
    class LeatherShoes : Finery
    {
        public override void Show()
        {
            Console.WriteLine("皮鞋");
            base.Show();
        }
    }
    #endregion
}
