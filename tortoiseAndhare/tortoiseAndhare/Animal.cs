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
        /// 60%機率前進
        /// 20%機率休息
        /// 20%機率後退
        /// </summary>
        public void Action()
        {
            Random rnd = new Random();
            int rate = rnd.Next(1, 101);
            if (rate > 40) Forward();
            if (rate > 20 && rate < 40) Rest();
            if (rate > 0 && rate < 20) GoBack();
        }

        /// <summary>
        /// 動物前進一步
        /// </summary>
        public void Forward()
        {
            chRange -= 1;
            Console.WriteLine("{0} 前進一步",chName);
        }

        /// <summary>
        /// 動物休息
        /// </summary>
        public void Rest()
        {
            chRange -= 0;
            Console.WriteLine("{0} 在休息", chName);
        }

        /// <summary>
        /// 動物後退一步
        /// </summary>
        public void GoBack()
        {
            chRange += 1;
            Console.WriteLine("{0} 後退一步", chName);
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
            Console.WriteLine(chName+ "剩餘：{0}",chRange);

        }
    }

}