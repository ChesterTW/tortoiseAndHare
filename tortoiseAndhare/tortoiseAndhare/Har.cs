using System;
namespace tortoiseAndhare
{
    public class Har:Animal
    {
        public Har(string name, int range) : base(name, range)
        {

        }

        /// <summary>
        /// 兔子的習性，50%的機率會呼叫 Jump()，50%機率會呼叫 Rest()。
        /// Jump()：前進二步
        /// Rest()：偷懶休息
        /// </summary>
        public void Behavior()
        {
            if (Move() > 50) Jump();
            if (Move() < 50) Rest();
        }

        /// <summary>
        /// 前進二步
        /// </summary>
        public void Jump()
        {
            chRange -= 2;
        }

        /// <summary>
        /// 偷懶休息
        /// </summary>
        public void Rest()
        {
            chRange -= 0;
        }

    }
}
