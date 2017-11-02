using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    #region 纯策略上下文
    //class CashContext
    //{
    //    private CashSuper cs;
    //    public CashContext(CashSuper cs)
    //    {
    //        this.cs = cs;
    //    }
    //    public double GetResult(double money)
    //    {
    //        return cs.acceptCash(money);
    //    }
    //}
    #endregion


    #region 策略与简单工厂结合上下文
    class CashContext
    {
        private CashSuper cs;
        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收费":
                    cs = new CashNormal();
                    break;
                case "满300返100":
                    cs = new CashReturn("300", "100");
                    break;
                case "打8折":
                    cs = new CashRebate("0.8");
                    break;
                default:
                    break;
            }
        }
        public double GetResult(double money)
        {
            return cs.acceptCash(money);
        }
    }
    #endregion
}
