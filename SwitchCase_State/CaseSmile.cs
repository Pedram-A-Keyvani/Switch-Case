namespace SwitchCase_State
{
    public class CaseSmile : SenseHolder, ICase<int?>
    {
        public int? Key { get { return 1; } }
        public override void Do()
        {
            Sense sense = new Sense();
            sense.Smile();
        }
    }
}
