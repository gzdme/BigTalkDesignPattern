using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    #region 互相耦合的类原型
    // 前台秘书类
    //class Secretary
    //{
    //    private IList<StockObserver> observers = new List<StockObserver>();
    //    private string _secretaryAction;
    //    public void Attach(StockObserver observer)
    //    {
    //        observers.Add(observer);
    //    }

    //    public void Notify()
    //    {
    //        foreach (StockObserver o in observers)
    //        {
    //            o.Update();
    //        }
    //    }

    //    public string SecretaryAction
    //    {
    //        get { return _secretaryAction; }
    //        set { _secretaryAction = value; }
    //    }
    //}
    //class StockObserver
    //{
    //    private string name;
    //    private Secretary sub;
    //    public StockObserver(string name, Secretary sub)
    //    {
    //        this.name = name;
    //        this.sub = sub;
    //    }
    //    public void Update()
    //    {
    //        Console.WriteLine("{0} {1} 关闭股票行情，继续工作！", sub.SecretaryAction, name);
    //    }
    //}
    #endregion

    #region 解耦实践一：没有对观察者进行抽象
    //abstract class Observer
    //{
    //    protected string name;
    //    protected Secretary sub;

    //    public Observer(string name, Secretary sub)
    //    {
    //        this.name = name;
    //        this.sub = sub;
    //    }

    //    public abstract void Update();
    //}
    //class StockObserver : Observer
    //{
    //    public StockObserver(string name, Secretary sub) : base(name, sub)
    //    {
    //    }

    //    public override void Update()
    //    {
    //        Console.WriteLine("{0} {1} 关闭股票行情，继续工作！", sub.SecretaryAction, name);
    //    }
    //}
    //class NBAObserver : Observer
    //{
    //    public NBAObserver(string name, Secretary sub) : base(name, sub)
    //    {
    //    }

    //    public override void Update()
    //    {
    //        Console.WriteLine("{0} {1} 关闭NBA直播，继续工作！", sub.SecretaryAction, name);
    //    }
    //}
    //// 具体通知者：前台小姐类
    //class Secretary
    //{
    //    // 同事列表
    //    private IList<Observer> observers = new List<Observer>();
    //    private string _secretaryAction;

    //    // 增加
    //    public void Attact(Observer observer)
    //    {
    //        observers.Add(observer);
    //    }
    //    // 减少
    //    public void Detach(Observer observer)
    //    {
    //        observers.Remove(observer);
    //    }
    //    // 通知
    //    public void Notify()
    //    {
    //        foreach (Observer o in observers)
    //        {
    //            o.Update();
    //        }
    //    }

    //    // 前台状态
    //    public string SecretaryAction
    //    {
    //        get { return _secretaryAction; }
    //        set { _secretaryAction = value; }
    //    }
    //}
    #endregion

    #region 抽象观察者
    //// 通知者接口
    //interface Subject
    //{
    //    void Attach(Observer observer);
    //    void Detach(Observer observer);
    //    void Notify();
    //    string SubjectState
    //    {
    //        get;
    //        set;
    //    }
    //}
    //// 具体通知者：老板
    //class Boss : Subject
    //{
    //    // 同事列表
    //    private IList<Observer> observers = new List<Observer>();
    //    private string _secretaryAction;
    //    public string SubjectState { get => _secretaryAction; set => this._secretaryAction = value; }

    //    // 增加
    //    public void Attach(Observer observer)
    //    {
    //        observers.Add(observer);
    //    }
    //    // 减少
    //    public void Detach(Observer observer)
    //    {
    //        observers.Remove(observer);
    //    }
    //    // 通知
    //    public void Notify()
    //    {
    //        foreach (Observer o in observers)
    //        {
    //            o.Update();
    //        }
    //    }
    //    // 老板状态
    //    public string SecretaryAction
    //    {
    //        get { return _secretaryAction; }
    //        set { _secretaryAction = value; }
    //    }
    //}
    //// 具体通知者：前台小姐类
    //class Secretary : Subject
    //{
    //    // 同事列表
    //    private IList<Observer> observers = new List<Observer>();
    //    private string _secretaryAction;

    //    // 增加
    //    public void Attach(Observer observer)
    //    {
    //        observers.Add(observer);
    //    }
    //    // 减少
    //    public void Detach(Observer observer)
    //    {
    //        observers.Remove(observer);
    //    }
    //    // 通知
    //    public void Notify()
    //    {
    //        foreach (Observer o in observers)
    //        {
    //            o.Update();
    //        }
    //    }

    //    // 前台状态
    //    public string SecretaryAction
    //    {
    //        get { return _secretaryAction; }
    //        set { _secretaryAction = value; }
    //    }

    //    public string SubjectState { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //}
    //// 抽象观察者
    //abstract class Observer
    //{
    //    protected string name;
    //    protected Subject sub;          // 修改为抽象通知者

    //    public Observer(string name, Subject sub)
    //    {
    //        this.name = name;
    //        this.sub = sub;
    //    }

    //    public abstract void Update();
    //}
    //class StockObserver : Observer
    //{
    //    public StockObserver(string name, Subject sub) : base(name, sub)
    //    {
    //    }

    //    public override void Update()
    //    {
    //        Console.WriteLine("{0} {1} 关闭股票行情，继续工作！", sub.SubjectState, name);
    //    }
    //}
    //class NBAObserver : Observer
    //{
    //    public NBAObserver(string name, Subject sub) : base(name, sub)
    //    {
    //    }

    //    public override void Update()
    //    {
    //        Console.WriteLine("{0} {1} 关闭NBA直播，继续工作！", sub.SubjectState, name);
    //    }
    //}
    #endregion

    #region 对观察者使用委托
    class StockObserver
    {
        protected string name;
        protected Subject sub;          // 修改为抽象通知者

        public StockObserver(string name, Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public void CloseStockMarket()
        {
            Console.WriteLine("{0} {1} 关闭股票行情，继续工作！", sub.SubjectState, name);
        }
    }
    class NBAObserver
    {
        protected string name;
        protected Subject sub;          // 修改为抽象通知者

        public NBAObserver(string name, Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public void CloseNBADirectSeeding()
        {
            Console.WriteLine("{0} {1} 关闭NBA直播，继续工作！", sub.SubjectState, name);
        }
    }
    // 通知者接口
    interface Subject
    {
        //去除增加方法，void Attach(Observer observer);
        //去除移除方法，void Detach(Observer observer);
        void Notify();
        string SubjectState
        {
            get;
            set;
        }
    }
    delegate void EventHandler();
    class Boss : Subject
    {
        private string _subjectState;

        public event EventHandler Update;
        public string SubjectState
        {
            get => _subjectState;
            set => _subjectState = value;
        }

        public void Notify()
        {
            Update();
        }
    }
    class Secretary : Subject
    {
        private string _subjectState;

        public event EventHandler Update;
        public string SubjectState
        {
            get => _subjectState;
            set => _subjectState = value;
        }

        public void Notify()
        {
            Update();
        }
    }
    #endregion
}
