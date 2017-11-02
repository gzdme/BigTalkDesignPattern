using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 外观模式
{
    class Stock1
    {
        // 买股票
        public void Sell()
        {
            Console.WriteLine(" 股票1卖出");
        }
        // 卖股票
        public void Buy()
        {
            Console.WriteLine(" 股票1买入");
        }
    }
    class Stock2
    {
        // 买股票
        public void Sell()
        {
            Console.WriteLine(" 股票2卖出");
        }
        // 卖股票
        public void Buy()
        {
            Console.WriteLine(" 股票2买入");
        }
    }
    class Stock3
    {
        // 买股票
        public void Sell()
        {
            Console.WriteLine(" 股票3卖出");
        }
        // 卖股票
        public void Buy()
        {
            Console.WriteLine(" 股票3买入");
        }
    }
    class NationalDebt1
    {
        // 买股票
        public void Sell()
        {
            Console.WriteLine(" 国债1卖出");
        }
        // 卖股票
        public void Buy()
        {
            Console.WriteLine(" 国债1买入");
        }
    }
    class Realty1
    {
        // 买股票
        public void Sell()
        {
            Console.WriteLine(" 房产1卖出");
        }
        // 卖股票
        public void Buy()
        {
            Console.WriteLine(" 房产1买入");
        }
    }
}
