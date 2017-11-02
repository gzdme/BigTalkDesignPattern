using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    #region 没有代理的实现
    //// 被追求者类
    //class SchoolGirl
    //{
    //    private string _name;
    //    public string Name
    //    {
    //        get { return _name; }
    //        set { _name = value; }
    //    }
    //}
    //// 追求者类
    //class Pursuit
    //{
    //    SchoolGirl mm;
    //    public Pursuit(SchoolGirl mm)
    //    {
    //        this.mm = mm;
    //    }
    //    public void GiveDolls()
    //    {
    //        Console.WriteLine(mm.Name + " 送你洋娃娃");
    //    }
    //    public void GiveFlowers()
    //    {
    //        Console.WriteLine(mm.Name + " 送你鲜花");
    //    }
    //    public void GiveChocolate()
    //    {
    //        Console.WriteLine(mm.Name + " 送你巧克力");
    //    }
    //}
    #endregion

    #region 代理模式
    // 被追求者类
    class SchoolGirl
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
    // 代理接口
    interface IGiveGift
    {
        void GiveDolls();
        void GiveFlowers();
        void GiveChocolate();
    }
    // 追求者类
    class Pursuit : IGiveGift
    {
        SchoolGirl mm;
        public Pursuit(SchoolGirl mm)
        {
            this.mm = mm;
        }
        public void GiveDolls()
        {
            Console.WriteLine(mm.Name + " 送你洋娃娃");
        }
        public void GiveFlowers()
        {
            Console.WriteLine(mm.Name + " 送你鲜花");
        }
        public void GiveChocolate()
        {
            Console.WriteLine(mm.Name + " 送你巧克力");
        }
    }
    class ProxyA : IGiveGift
    {
        Pursuit gg;
        public ProxyA(SchoolGirl mm)
        {
            gg = new Pursuit(mm);
        }
        public void GiveDolls()
        {
            gg.GiveDolls();
        }
        public void GiveFlowers()
        {
            gg.GiveFlowers();
        }
        public void GiveChocolate()
        {
            gg.GiveChocolate();
        }
    }
    #endregion
}
