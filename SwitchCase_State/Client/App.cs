using SwitchCase_State.Server.GreetingCondition;
using SwitchCase_State.Server.SenseCondition;
using System;

namespace SwitchCase_State.Client
{
    public static class App
    {
        public static void Run()
        {
            int sense = 1;
            ConditionSense conditionSense = new ConditionSense();
            conditionSense.Switch(sense);

            Console.WriteLine("then");

            string greeting = "Bye";
            ConditionGreeting conditionSpeech = new ConditionGreeting();
            conditionSpeech.Switch(greeting, "see you then.");

            Console.ReadKey();
        }
    }
}
