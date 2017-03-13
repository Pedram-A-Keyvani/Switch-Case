using SwitchCase_State.Server.ConditionActions;

namespace SwitchCase_State.Server.SenseCondition.Cases
{
    public class CaseCry : IAction, ICase<int?>
    {
        public int? Key { get { return 2; } }

        public void Do()
        {
            Sense.Cry cry = new Sense.Cry();
            cry.Act();
        }
    }
}
