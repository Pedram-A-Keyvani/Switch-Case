using SwitchCase_State.Server.ConditionActions;

namespace SwitchCase_State.Server.GreetingCondition.Cases
{
    public class CaseBye : ISpeech<IGreeting>, ICase<string>
    {
        public string Key { get { return "Bye"; } }

        public void Say(string message, IGreeting greeting)
        {
            greeting.SayByeThen(message);
        }
    }
}
