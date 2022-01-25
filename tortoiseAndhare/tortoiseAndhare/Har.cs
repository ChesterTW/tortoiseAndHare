using System;
namespace tortoiseAndhare
{
    class Har : Animal
    {
        public Har(string name, int range) : base(name, range)
        {

        }

        /// <summary>
        /// 60%機率前跳
        /// 30%機率休息
        /// 10%機率後跳
        /// </summary>
        public override void Action()
        {
            Random rnd = new Random();
            GoRate = rnd.Next(1, 101);

            if (GoRate > 40) Forward();
            if (GoRate > 10 && GoRate <= 40) Rest();
            if (GoRate > 0 && GoRate <= 10) GoBack();
        }

        /// <summary>
        /// 60%機率前跳
        /// 兔子前跳：50%機率兩步、50%機率一步
        /// </summary>
        public override void Forward()
        {
            if ((GoRate/2)>30)
            {
                chRange -= 2;
                Console.WriteLine("{0} 跳了兩步", chName);
            }
            else
            {
                chRange -= 1;
                Console.WriteLine("{0} 跳了一步", chName);
            }
        }

        /// <summary>
        /// 兔子休息
        /// </summary>
        public override void Rest()
        {
            chRange -= 0;
            Console.WriteLine("{0} 在休息", chName);
        }

        /// <summary>
        /// 兔子後跳一步
        /// </summary>
        public override void GoBack()
        {
            chRange += 1;
            Console.WriteLine("{0} 後跳一步", chName);
        }

    }
}
