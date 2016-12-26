using System;
namespace SwitchCase_State
{
    public class Greeting
    {
        public void Hi(string message)
        {
            Console.WriteLine($"Hi, {message}");
        }
        public void Bye(string message)
        {
            Console.WriteLine($"Bye, {message}");
        }
    }
}
