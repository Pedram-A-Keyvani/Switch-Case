using SwitchCase_State.Server.ConditionActions;
using System;

namespace SwitchCase_State.Server.SenseCondition
{
    public class Sense
    {
        public class Smile
        {
            public void Act()
            {
                Console.WriteLine("I'm smiling :-)");
            }
        }

        public class Cry
        {
            public void Act()
            {
                Console.WriteLine("I'm crying :-(");
            }
        }

        public class NoSense
        {
            public void Act()
            {
                Console.WriteLine("I've no scence :-|");
            }
        }
    }
}
