using System.Collections.Generic;
using System.Linq;

namespace SwitchCase_State
{
    public class ConditionSense : SwitchCase<int?>
    {
        public ConditionSense()
        {
            Cases = new List<ICase<int?>>
                {
                    new CaseSmile(),
                    new CaseCry()
                };
            DefaultCases = new List<ICase<int?>> {
                new CaseNoSense()
            };
        }
        public void Switch(int? key)
        {
            IEnumerable<SenseHolder> matches = Cases.Where(p => p.Key.Equals(key)).Select(p => p as SenseHolder);
            if (matches.Count() > 0)
                foreach (SenseHolder match in matches)
                    match.Do();
            else
                foreach (SenseHolder defaultCase in DefaultCases)
                    defaultCase.Do();
        }
    }
}
