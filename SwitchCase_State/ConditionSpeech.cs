using System.Collections.Generic;
using System.Linq;

namespace SwitchCase_State
{
    public class ConditionSpeech : SwitchCase<string>
    {
        public ConditionSpeech()
        {
            Cases = new List<ICase<string>>
                {
                    new CaseHi(),
                    new CaseBye()
                };
        }
        public virtual void Switch(string key, string message)
        {
            IEnumerable<SpeechHolder> matches = Cases.Where(p => p.Key.Equals(key)).Select(p => p as SpeechHolder);
            if (matches.Count() > 0)
                foreach (SpeechHolder match in matches)
                    match.Say(message);
        }
    }
}
