using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 备忘录模式
{
    class Program
    {
        #region 过程式实现，暴露类内部结构和字段
        //static void Main(string[] args)
        //{
        //    // 大战Boss前
        //    GameRole lixiaoyao = new GameRole();
        //    lixiaoyao.GetInitState();
        //    lixiaoyao.StateDisplay();

        //    // 保存进度
        //    GameRole backup = new GameRole();
        //    backup.Vitality = lixiaoyao.Vitality;
        //    backup.Attack = lixiaoyao.Attack;
        //    backup.Defense = lixiaoyao.Defense;

        //    // 大战Boss时， 损耗严重
        //    lixiaoyao.Fight();
        //    lixiaoyao.StateDisplay();

        //    // 恢复之前的状态
        //    lixiaoyao.Vitality = backup.Vitality;
        //    lixiaoyao.Attack = backup.Attack;
        //    lixiaoyao.Defense = backup.Defense;

        //    lixiaoyao.StateDisplay();

        //    Console.Read();
        //}
        #endregion

        #region 使用备忘录模式的客户端实现代码
        static void Main(string[] args)
        {
            // 大战Boss前
            GameRole lixiaoyao = new GameRole();
            lixiaoyao.GetInitState();
            lixiaoyao.StateDisplay();

            // 保存进度
            RoleStateCaretaker stateAdmin = new RoleStateCaretaker();
            stateAdmin.Memento = lixiaoyao.SaveState();

            // 大战Boss时， 损耗严重
            lixiaoyao.Fight();
            lixiaoyao.StateDisplay();

            // 恢复之前的状态
            lixiaoyao.RecoveryState(stateAdmin.Memento);

            lixiaoyao.StateDisplay();

            Console.Read();
        }
        #endregion
    }
}
