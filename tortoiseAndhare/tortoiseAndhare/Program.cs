using System;
using System.Collections.Generic;

namespace tortoiseAndhare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入賽道長度：");
            // 輸入賽道長度
            if(int.TryParse(Console.ReadLine(),out int range))
            {
                // 顯示遊戲開始字串，並等待下一步
                Console.WriteLine("按任意按鍵開始遊戲");
                Console.ReadKey();

                Tor tor = new Tor("Tor", range);
                Har har = new Har("Har", range);

                // 遊戲執行
                for (int i = 0;i>-1; i++)
                {
                    // 賽道重置
                    Console.Clear();

                    // 顯示使用者按了幾次按鍵
                    Show_Tme(i);

                    /// 顯示角色剩餘的賽道、角色的名稱。
                    tor.Show_Circult();
                    har.Show_Circult();

                    // 角色前進
                    tor.Behavior();
                    har.Behavior();

                    // 確認角色是否勝利
                    if (tor.ChWinOrNot)
                    {
                        Console.WriteLine("恭喜！ {0} 為贏家！！！", tor.chName);
                        goto FINISH;
                    }
                    if (har.ChWinOrNot)
                    {
                        Console.WriteLine("恭喜！ {0} 為贏家！！！", har.chName);
                        goto FINISH;
                    }

                    // 下一回合，等待使用者按按鍵
                    Console.ReadKey();
                }

                FINISH:

                // 遊戲結束
                Console.WriteLine("按任意按鍵結束遊戲");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// 顯示使用者按了幾次按鍵
        /// </summary>
        /// <param name="second">i</param>
        private static void Show_Tme(int second)
        {
            Console.WriteLine("第{0}秒",second);
        }
    }
}
