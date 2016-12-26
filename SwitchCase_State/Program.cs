using System;

namespace SwitchCase_State
{
    class Program
    {
        static void Main(string[] args)
        {
            int sense = 1;
            new ConditionSense().Switch(sense);

            Console.WriteLine("then");

            string greeting = "Bye";
            new ConditionSpeech().Switch(greeting, "see you then.");

            Console.ReadKey();
        }
    }
}
