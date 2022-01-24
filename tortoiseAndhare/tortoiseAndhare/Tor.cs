using System;
namespace tortoiseAndhare
{
    public class Tor:Animal
    {
        public Tor(string name, int range) : base(name, range)
        {

        }

        public void Behavior()
        {
            if (Action() > 0) Crawl();
        }

        public void Crawl()
        {
            chRange -= 1;
        }
    }
}
