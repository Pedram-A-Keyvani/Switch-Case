using SwitchCase_State.Server.ConditionActions;

namespace SwitchCase_State.Server.GreetingCondition.Cases
{
    public class CaseBye : ISpeech, ICase<string>
    {
        public string Key { get { return "Bye"; } }

        public void Say(string message)
        {
            Greeting.Bye bye = new Greeting.Bye();
            bye.SayByeThen(message);
        }
    }
}
