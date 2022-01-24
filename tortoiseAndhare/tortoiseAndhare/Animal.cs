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
                if (chRange == 0)
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
        /// 產生0至100的亂數。
        /// </summary>
        public int Move()
        {
            Random random = new Random();
            int chance = random.Next(0, 101);

            return chance;
        }

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

        }
    }

}