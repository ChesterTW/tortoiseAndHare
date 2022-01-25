using System;
namespace tortoiseAndhare
{
    class Tor : Animal
    {
        public Tor(string name, int range) : base(name, range)
        {

        }

        /// <summary>
        /// 80%機率前爬
        /// 20%機率休息
        /// </summary>
        public override void Action()
        {
            Random rnd = new Random();
            GoRate = rnd.Next(1, 101);
            if (GoRate > 20) Forward();
            if (GoRate <= 20) Rest();
        }

        /// <summary>
        /// 烏龜爬了一步
        /// </summary>
        public override void Forward()
        {
            chRange -= 1;
            Console.WriteLine("{0} 爬了一步", chName);
        }

        public override void GoBack()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 烏龜休息
        /// </summary>
        public override void Rest()
        {
            chRange -= 0;
            Console.WriteLine("{0} 在休息", chName);
        }

    }
}
