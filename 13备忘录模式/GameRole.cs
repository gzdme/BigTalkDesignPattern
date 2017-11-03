using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 备忘录模式
{
    #region 过程式实现
    //class GameRole
    //{
    //    private int _vitality;
    //    private int _attack;
    //    private int _defense;
    //    /// <summary>
    //    /// 生命力
    //    /// </summary>
    //    public int Vitality
    //    {
    //        get { return _vitality; }
    //        set { _vitality = value; }
    //    }
    //    /// <summary>
    //    /// 攻击力
    //    /// </summary>
    //    public int Attack
    //    {
    //        get { return _attack; }
    //        set { _attack = value; }
    //    }
    //    /// <summary>
    //    /// 防御力
    //    /// </summary>
    //    public int Defense
    //    {
    //        get { return _defense; }
    //        set { _defense = value; }
    //    }
    //    // 状态显示
    //    public void StateDisplay()
    //    {
    //        Console.WriteLine("角色当前状态：");
    //        Console.WriteLine("生命力：{0}", this._vitality);
    //        Console.WriteLine("攻击力：{0}", this._attack);
    //        Console.WriteLine("防御力：{0}", this._defense);
    //        Console.WriteLine("");
    //    }
    //    // 获得初始状态
    //    public void GetInitState()
    //    {
    //        this._vitality = 100;
    //        this._attack = 100;
    //        this._defense = 100;
    //    }
    //    // 战斗
    //    public void Fight()
    //    {
    //        this._vitality = 0;
    //        this._attack = 0;
    //        this._defense = 0;
    //    }
    //}
    #endregion

    class GameRole
    {
        private int _vitality;
        private int _attack;
        private int _defense;
        /// <summary>
        /// 生命力
        /// </summary>
        public int Vitality
        {
            get { return _vitality; }
            set { _vitality = value; }
        }
        /// <summary>
        /// 攻击力
        /// </summary>
        public int Attack
        {
            get { return _attack; }
            set { _attack = value; }
        }
        /// <summary>
        /// 防御力
        /// </summary>
        public int Defense
        {
            get { return _defense; }
            set { _defense = value; }
        }

        // 状态显示
        public void StateDisplay()
        {
            Console.WriteLine("角色当前状态：");
            Console.WriteLine("生命力：{0}", this._vitality);
            Console.WriteLine("攻击力：{0}", this._attack);
            Console.WriteLine("防御力：{0}", this._defense);
            Console.WriteLine("");
        }
        // 获得初始状态
        public void GetInitState()
        {
            this._vitality = 100;
            this._attack = 100;
            this._defense = 100;
        }
        // 战斗
        public void Fight()
        {
            this._vitality = 0;
            this._attack = 0;
            this._defense = 0;
        }

        // 保存角色状态
        public RoleStateMemento SaveState()
        {
            return (new RoleStateMemento(_vitality, _attack, _defense));
        }

        // 恢复角色状态
        public void RecoveryState(RoleStateMemento memento)
        {
            this._vitality = memento.Vitality;
            this._attack = memento.Attack;
            this._defense = memento.Defense;
        }
    }
    // 角色状态存储箱
    class RoleStateMemento
    {
        private int _vitality;
        private int _attack;
        private int _defense;

        public RoleStateMemento(int vitality, int attack, int defense)
        {
            this._vitality = vitality;
            this._attack = attack;
            this._defense = defense;
        }

        /// <summary>
        /// 生命力
        /// </summary>
        public int Vitality
        {
            get { return _vitality; }
        }
        /// <summary>
        /// 攻击力
        /// </summary>
        public int Attack
        {
            get { return _attack; }
        }
        /// <summary>
        /// 防御力
        /// </summary>
        public int Defense
        {
            get { return _defense; }
        }
    }
    // 角色状态管理者
    class RoleStateCaretaker
    {
        private RoleStateMemento _memento;

        public RoleStateMemento Memento
        {
            get { return _memento; }
            set { _memento = value; }
        }
    }
}
