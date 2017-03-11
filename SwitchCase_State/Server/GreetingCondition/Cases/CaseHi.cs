using SwitchCase_State.Server.ConditionActions;

namespace SwitchCase_State.Server.GreetingCondition.Cases
{
    public class CaseHi : ISpeech<IGreeting>, ICase<string>
    {
        public string Key { get { return "Hi"; } }

        public void Say(string message, IGreeting greeting)
        {
            greeting.SayHiThen(message);
        }
    }
}
