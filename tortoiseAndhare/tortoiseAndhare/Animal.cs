using System;
namespace tortoiseAndhare
{
    public class Animal
    {
        /// <summary>
        /// 角色名稱
        /// </summary>
        public string chName { get; set; }

        /// <summary>
        /// 角色與終點的距離
        /// </summary>
        public int chRange { get; set; }

        /// <summary>
        /// 角色是否勝利
        /// </summary>
        public Boolean chWinOrNot { get; set; }

        public int GoRate { get; set; }

        /// <summary>
        /// 建構函式 需String 和int
        /// </summary>
        /// <param name="name"></param>
        /// <param name="range"></param>
        public Animal(string name, int range)
        {
            chName = name;
            chRange = range;
        }

        /// <summary>
        /// 確認該角色是否勝利
        /// </summary>
        public Boolean ChWinOrNot
        {
            get
            {
                if (chRange <= 0)
                {
                    chWinOrNot = true;
                }
                else
                {
                    chWinOrNot = false;
                }
                return chWinOrNot;
            }
        }

        /// <summary>
        /// 動物機率
        /// </summary>
        public virtual void Action() { }

        /// <summary>
        /// 動物前進
        /// </summary>
        public virtual void Forward() { }

        /// <summary>
        /// 動物休息
        /// </summary>
        public virtual void Rest() { }

        /// <summary>
        /// 動物後退
        /// </summary>
        public virtual void GoBack() { }

        /// <summary>
        /// 顯示角色剩餘的賽道、角色的名稱。
        /// </summary>
        public void Show_Circult()
        {
            for (int i = 0; i < chRange; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine(chName);
            Console.WriteLine(chName+ "剩餘：{0}",chRange);

        }
    }

}