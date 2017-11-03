using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 过程演示代码
            //// 前台小姐童子喆
            //Secretary tongzizhe = new Secretary();
            //// 看股票的同事
            //StockObserver tongshi1 = new StockObserver("魏观姹", tongzizhe);
            //StockObserver tongshi2 = new StockObserver("易管查", tongzizhe);

            //// 前台记下了两位同事
            //tongzizhe.Attach(tongshi1);
            //tongzizhe.Attach(tongshi2);
            //// 发现老板回来
            //tongzizhe.SecretaryAction = "老板回来了！";
            //// 通知两个同事
            //tongzizhe.Notify();
            #endregion

            #region 使用观察者模式代码
            // 老板胡汉三
            //Boss huhansan = new Boss();
            //// 看股票的同事
            //StockObserver tongshi1 = new StockObserver("魏观姹", huhansan);
            //// 看NBA的同事
            //NBAObserver tongshi2 = new NBAObserver("易管查", huhansan);
            //huhansan.Attach(tongshi1);
            //huhansan.Attach(tongshi2);

            //// 同事二未被通知到，移除
            //huhansan.Detach(tongshi1);

            //// 老板回来
            //huhansan.SubjectState = "我胡汉三回来了！";
            //// 发出通知
            //huhansan.Notify();
            #endregion

            //老板胡汉三
            Boss huhansan = new Boss();
            Secretary secretary = new Secretary();
            // 看股票的同事
            StockObserver tongshi1 = new StockObserver("魏观姹", huhansan);
            // 看NBA的同事
            NBAObserver tongshi2 = new NBAObserver("易管查", secretary);

            huhansan.Update += tongshi1.CloseStockMarket;
            secretary.Update += tongshi2.CloseNBADirectSeeding;

            // 老板回来
            huhansan.SubjectState = "我胡汉三回来了！";
            // 发出通知
            huhansan.Notify();
            // 前台报告
            secretary.SubjectState = "老板回来了！";
            // 发出通知
            secretary.Notify();

            Console.Read();
        }
    }
}
