using System;

namespace SwitchCase_State.Server.GreetingCondition
{
    public class Greeting : IGreeting
    {
        public void SayHiThen(string message)
        {
            Console.WriteLine($"Hi, {message}");
        }

        public void SayByeThen(string message)
        {
            Console.WriteLine($"Bye, {message}");
        }
    }
}
