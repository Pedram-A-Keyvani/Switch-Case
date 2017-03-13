using System;

namespace SwitchCase_State.Server.GreetingCondition
{
    public class Greeting
    {
        public class Hi
        {
            public void SayHiThen(string message)
            {
                Console.WriteLine($"Hi, {message}");
            }
        }

        public class Bye
        {
            public void SayByeThen(string message)
            {
                Console.WriteLine($"Bye, {message}");
            }
        }
    }
}
