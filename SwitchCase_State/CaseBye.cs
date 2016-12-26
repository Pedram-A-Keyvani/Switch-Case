using System;

namespace SwitchCase_State
{
    public class CaseBye : SpeechHolder, ICase<string>
    {
        public string Key { get { return "Bye"; } }
        public override void Say(string message)
        {
            Greeting greeting = new Greeting();
            greeting.Bye(message);
        }
    }
}
