namespace SwitchCase_State
{
    public class CaseNoSense : SenseHolder, ICase<int?>
    {
        public int? Key { get { return null; } }
        public override void Do()
        {
            Sense sense = new Sense();
            sense.NoSense();
        }
    }
}
