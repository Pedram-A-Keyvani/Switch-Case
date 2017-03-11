using SwitchCase_State.Server.ConditionActions;
using SwitchCase_State.Server.GreetingCondition.Cases;
using System.Collections.Generic;
using System.Linq;

namespace SwitchCase_State.Server.GreetingCondition
{
    public class ConditionGreeting : SwitchCase<string>
    {
        public ConditionGreeting()
        {
            Cases = new List<ICase<string>>
                {
                    new CaseHi(),
                    new CaseBye()
                };
        }

        public virtual void Switch(string key, string message)
        {
            IGreeting greeting = new Greeting();

            IEnumerable<ISpeech<IGreeting>> matches = Cases.Where(p => p.Key.Equals(key)).Select(p => p as ISpeech<IGreeting>);
            if (matches.Count() > 0)
                foreach (ISpeech<IGreeting> match in matches)
                    match.Say(message, greeting);
        }
    }
}
