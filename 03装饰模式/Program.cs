using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    class Program
    {
        #region 过程式的客户端实现
        //static void Main(string[] args)
        //{
        //    Person person = new Person("小菜");
        //    Console.WriteLine("\n 第一种装扮： ");

        //    person.WearTShirts();
        //    person.WearBigTrouser();
        //    person.WearSneakers();
        //    person.Show();

        //    Console.WriteLine("\n 第二种装扮： ");
        //    person.WearSuit();
        //    person.WearTie();
        //    person.WearLeatherShoes();
        //    person.Show();

        //    Console.Read();
        //}
        #endregion

        #region 考虑开放-封闭原则，拆解后的客户端实现
        //static void Main(string[] args)
        //{
        //    Person person = new Person("小菜");
        //    Console.WriteLine("\n 第一种装扮： ");

        //    Finery dtx = new TShirts();
        //    Finery kk = new BigTrouser();
        //    Finery pqx = new Sneakers();
        //    dtx.Show();
        //    kk.Show();
        //    pqx.Show();
        //    person.Show();

        //    Console.WriteLine("\n 第二种装扮： ");
        //    Finery xz = new Suit();
        //    Finery ld = new Tie();
        //    Finery px = new LeatherShoes();
        //    xz.Show();
        //    ld.Show();
        //    px.Show();
        //    person.Show();

        //    Console.Read();
        //}
        #endregion

        #region 使用装饰模式后的客户端实现
        static void Main(string[] args)
        {
            Person person = new Person("小菜");
            Console.WriteLine("\n 第一种装扮： ");

            Finery pqx = new Sneakers();
            Finery dtx = new TShirts();
            Finery kk = new BigTrouser();

            pqx.Decorate(person);
            kk.Decorate(pqx);
            dtx.Decorate(kk);
            dtx.Show();

            Console.WriteLine("\n 第二种装扮： ");
            Finery px = new LeatherShoes();
            Finery ld = new Tie();
            Finery xz = new Suit();
            px.Decorate(person);
            ld.Decorate(px);
            xz.Decorate(ld);
            xz.Show();

            Console.Read();
        }
        #endregion
    }
}
