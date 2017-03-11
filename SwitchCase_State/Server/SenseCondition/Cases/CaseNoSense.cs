using SwitchCase_State.Server.ConditionActions;

namespace SwitchCase_State.Server.SenseCondition.Cases
{
    public class CaseNoSense : IAction, ICase<int?>
    {
        public int? Key { get { return null; } }

        public void Sense(ISense sense)
        {
            sense.NoSense();
        }
    }
}
