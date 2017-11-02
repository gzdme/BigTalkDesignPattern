using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    class Program
    {
        #region  没有代理的客户端实现
        //static void Main(string[] args)
        //{
        //    SchoolGirl jiaojiao = new SchoolGirl();
        //    jiaojiao.Name = "娇娇";

        //    Pursuit zhuojiayi = new Pursuit(jiaojiao);

        //    zhuojiayi.GiveDolls();
        //    zhuojiayi.GiveFlowers();
        //    zhuojiayi.GiveChocolate();

        //    Console.Read();
        //}
        #endregion

        #region  代理模式的客户端实现
        static void Main(string[] args)
        {
            SchoolGirl jiaojiao = new SchoolGirl();
            jiaojiao.Name = "娇娇";

            ProxyA daili = new ProxyA(jiaojiao);

            daili.GiveDolls();
            daili.GiveFlowers();
            daili.GiveChocolate();

            Console.Read();
        }
        #endregion
    }
}
