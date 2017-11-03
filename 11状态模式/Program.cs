using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 状态模式
{
    class Program
    {
        #region 过程式实现
        //static int Hour = 0; //钟点
        //static bool WorkFinished = false; //任务完成标记
        //public static void WriteProgram()
        //{
        //    if (Hour < 12)
        //    {
        //        Console.WriteLine("当前时间： {0}点 上午工作， 精神百倍", Hour);
        //    }
        //    else if (Hour < 13)
        //    {
        //        Console.WriteLine("当前时间： {0}点 饿了， 午饭；犯困， 午休", Hour);
        //    }
        //    else if (Hour < 17)
        //    {
        //        Console.WriteLine("当前时间： {0}点 下午状态还不错， 继续努力", Hour);
        //    }
        //    else
        //    {
        //        if (WorkFinished)
        //        {
        //            Console.WriteLine("当前时间： {0}点 下班回家了", Hour);
        //        }
        //        else
        //        {
        //            if (Hour < 21)
        //            {
        //                Console.WriteLine("当前时间： {0}点 加班哦， 疲累之极", Hour);
        //            }
        //            else
        //            {
        //                Console.WriteLine("当前时间： {0}点 不行了， 睡着了。", Hour);
        //            }
        //        }
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    Hour = 9;
        //    WriteProgram();
        //    Hour = 10;
        //    WriteProgram();
        //    Hour = 11;
        //    WriteProgram();
        //    Hour = 12;
        //    WriteProgram();
        //    Hour = 13;
        //    WriteProgram();
        //    Hour = 14;
        //    WriteProgram();
        //    Hour = 17;
        //    WriteProgram();

        //    WorkFinished = true;
        //    //WorkFinished = false;

        //    WriteProgram();
        //    Hour = 19;
        //    WriteProgram();
        //    Hour = 22;
        //    WriteProgram();

        //    Console.Read();
        //}
        #endregion

        #region 使用面向对象实现，糟糕的长函数WriteProgram()
        static void Main(string[] args)
        {
            Work emergencyProjects = new Work();
            emergencyProjects.Hour = 9;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 10;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 12;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 13;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 14;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 17;
            emergencyProjects.WriteProgram();

            //emergencyProjects.TaskFinished = true;
            emergencyProjects.TaskFinished = false;

            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 19;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 20;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 21;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 22;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 23;
            emergencyProjects.WriteProgram();

            Console.Read();
        }
        #endregion
    }
}
