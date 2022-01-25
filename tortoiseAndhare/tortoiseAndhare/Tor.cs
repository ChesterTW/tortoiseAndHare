using System;
namespace tortoiseAndhare
{
    public class Tor:Animal
    {
        public Tor(string name, int range) : base(name, range)
        {

        }

        /// <summary>
        /// 80%機率前爬
        /// 20%機率休息
        /// </summary>
        public new void Action()
        {
            Random rnd = new Random();
            int rate = rnd.Next(1, 101);
            if (rate > 20) Forward();
            if (rate < 20) Rest();
        }

        /// <summary>
        /// 烏龜爬了一步
        /// </summary>
        public new void Forward()
        {
            chRange -= 1;
            Console.WriteLine("{0} 爬了一步", chName);
        }

        /// <summary>
        /// 烏龜休息
        /// </summary>
        public new void Rest()
        {
            chRange -= 0;
            Console.WriteLine("{0} 在休息", chName);
        }

    }
}
