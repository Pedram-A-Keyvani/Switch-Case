using SwitchCase_State.Server.ConditionActions;

namespace SwitchCase_State.Server.SenseCondition.Cases
{
    public class CaseSmile : IAction, ICase<int?>
    {
        public int? Key { get { return 1; } }


        public void Do()
        {
            Sense.Smile smile = new Sense.Smile();
            smile.Act();
        }
    }
}
