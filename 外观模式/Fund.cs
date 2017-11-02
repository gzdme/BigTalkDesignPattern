using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 外观模式
{
    class Fund
    {
        Stock1 stock1;
        Stock2 stock2;
        Stock3 stock3;
        NationalDebt1 nationalDebt1;
        Realty1 realty1;

        public Fund()
        {
            stock1 = new Stock1();
            stock2 = new Stock2();
            stock3 = new Stock3();
            nationalDebt1 = new NationalDebt1();
            realty1 = new Realty1();
        }
        public void BuyFund()
        {
            stock1.Buy();
            stock2.Buy();
            stock3.Buy();
            nationalDebt1.Buy();
            realty1.Buy();
        }
        public void SellFund()
        {
            stock1.Sell();
            stock2.Sell();
            stock3.Sell();
            nationalDebt1.Sell();
            realty1.Sell();
        }
    }
}
