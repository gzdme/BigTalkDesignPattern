using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 外观模式
{
    class Program
    {
        #region 普通类型调用
        //static void Main(string[] args)
        //{
        //    Stock1 stock1 = new Stock1();
        //    Stock2 stock2 = new Stock2();
        //    Stock3 stock3 = new Stock3();
        //    NationalDebt1 nationalDebt1 = new NationalDebt1();
        //    Realty1 realty1 = new Realty1();

        //    stock1.Buy();
        //    stock2.Buy();
        //    stock3.Buy();
        //    nationalDebt1.Buy();
        //    realty1.Buy();

        //    stock1.Sell();
        //    stock2.Sell();
        //    stock3.Sell();
        //    nationalDebt1.Sell();
        //    realty1.Sell();

        //    Console.Read();
        //}
        #endregion

        #region 使用外观模式后的客户端代码
        static void Main(string[] args)
        {
            Fund fund = new Fund();
            fund.BuyFund();
            fund.SellFund();

            Console.Read();
        }
        #endregion
    }
}
