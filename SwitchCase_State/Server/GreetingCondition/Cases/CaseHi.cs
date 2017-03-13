using SwitchCase_State.Server.ConditionActions;

namespace SwitchCase_State.Server.GreetingCondition.Cases
{
    public class CaseHi : ISpeech, ICase<string>
    {
        public string Key { get { return "Hi"; } }

        public void Say(string message)
        {
            Greeting.Hi hi = new Greeting.Hi();
            hi.SayHiThen(message);
        }
    }
}
