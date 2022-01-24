using System;
namespace tortoiseAndhare
{
    public class Har:Animal
    {
        public Har(string name,int range):base(name, range)
        {

        }

        public void Behavior()
        {
            if (Action() > 50) Jump();
            if (Action() < 50) Rest();
        }

        public void Jump()
        {
            chRange -= 2;
        }

        public void Rest()
        {
            chRange -= 0;
        }

    }
}
