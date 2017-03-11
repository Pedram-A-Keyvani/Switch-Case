using System;

namespace SwitchCase_State.Server.SenseCondition
{
    public class Sense : ISense
    {
        public void Smile()
        {
            Console.WriteLine("I'm smiling :-)");
        }

        public void Cry()
        {
            Console.WriteLine("I'm crying :-(");
        }

        public void NoSense()
        {
            Console.WriteLine("I've no scence :-|");
        }
    }
}
