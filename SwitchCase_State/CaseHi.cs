using System;

namespace SwitchCase_State
{
    public class CaseHi : SpeechHolder, ICase<string>
    {
        public string Key { get { return "Hi"; } }
        public override void Say(string message)
        {
            Greeting greeting = new Greeting();
            greeting.Hi(message);
        }
    }
}
