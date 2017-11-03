using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 状态模式
{
    #region 又臭又长的WriteProgram()
    //class Work
    //{
    //    private int _hour;

    //    public int Hour
    //    {
    //        get { return _hour; }
    //        set { _hour = value; }
    //    }
    //    private bool _taskFinished;

    //    public bool TaskFinished
    //    {
    //        get { return _taskFinished; }
    //        set { _taskFinished = value; }
    //    }
    //    public void WriteProgram()
    //    {
    //        if (Hour < 12)
    //        {
    //            Console.WriteLine("当前时间： {0}点 上午工作， 精神百倍", Hour);
    //        }
    //        else if (Hour < 13)
    //        {
    //            Console.WriteLine("当前时间： {0}点 饿了， 午饭；犯困， 午休", Hour);
    //        }
    //        else if (Hour < 17)
    //        {
    //            Console.WriteLine("当前时间： {0}点 下午状态还不错， 继续努力", Hour);
    //        }
    //        else
    //        {
    //            if (this._taskFinished)
    //            {
    //                Console.WriteLine("当前时间： {0}点 下班回家了", Hour);
    //            }
    //            else
    //            {
    //                if (Hour < 21)
    //                {
    //                    Console.WriteLine("当前时间： {0}点 加班哦， 疲累之极", Hour);
    //                }
    //                else
    //                {
    //                    Console.WriteLine("当前时间： {0}点 不行了， 睡着了。", Hour);
    //                }
    //            }
    //        }
    //    }
    //}
    #endregion

    #region 使用状态模式分解长函数
    public class Work
    {
        private int _hour;
        private bool _taskFinished;
        private WState _state;

        public Work()
        {
            _state = new ForenoonState();
        }

        public int Hour
        {
            get { return _hour; }
            set { _hour = value; }
        }
        public bool TaskFinished
        {
            get { return _taskFinished; }
            set { _taskFinished = value; }
        }
        public WState State
        {
            get { return _state; }
            set
            {
                _state = value;
            }
        }
        public void WriteProgram()
        {
            _state.WriteProgram(this);
        }
    }
    // 抽象状态
    public abstract class WState
    {
        public abstract void WriteProgram(Work work);
    }
    // 具体状态：上午和中午工作状态
    public class ForenoonState : WState
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 12)
            {
                Console.WriteLine("当前时间： {0}点 上午工作， 精神百倍", work.Hour);
            }
            else
            {
                work.State = new NoonState();
                work.WriteProgram();
            }
        }
    }
    public class NoonState : WState
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 13)
            {
                Console.WriteLine("当前时间： {0}点 饿了， 午饭；犯困， 午休", work.Hour);
            }
            else
            {
                work.State = new AfternoonState();
                work.WriteProgram();
            }
        }
    }
    public class AfternoonState : WState
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 17)
            {
                Console.WriteLine("当前时间： {0}点 下午状态还不错， 继续努力", work.Hour);
            }
            else
            {
                work.State = new EveningState();
                work.WriteProgram();
            }
        }
    }
    public class EveningState : WState
    {
        public override void WriteProgram(Work work)
        {
            if (work.TaskFinished)
            {
                work.State = new RestState();
                work.WriteProgram();
            }
            else
            {
                if (work.Hour < 21)
                {
                    Console.WriteLine("当前时间： {0}点 加班哦， 疲累之极", work.Hour);
                }
                else
                {
                    work.State = new SleepingState();
                    work.WriteProgram();
                }
            }
        }
    }
    public class SleepingState : WState
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine("当前时间： {0}点 不行了， 睡着了。", work.Hour);
        }
    }
    public class RestState : WState
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine("当前时间： {0}点 下班回家了。", work.Hour);
        }
    }
    #endregion
}
