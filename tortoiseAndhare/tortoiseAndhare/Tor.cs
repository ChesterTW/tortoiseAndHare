using System;
namespace tortoiseAndhare
{
    public class Tor:Animal
    {
        public Tor(string name, int range) : base(name, range)
        {

        }

        /// <summary>
        /// 烏龜的習性，100%的機率會呼叫 Crawl()。
        /// Crawl()：前進一步
        /// </summary>
        public void Behavior()
        {
            if (Move() > 0) Crawl();
        }

        /// <summary>
        /// 前進一步
        /// </summary>
        public void Crawl()
        {
            chRange -= 1;
        }
    }
}
