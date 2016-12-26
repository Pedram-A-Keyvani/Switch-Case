namespace SwitchCase_State
{
    public class CaseCry : SenseHolder, ICase<int?>
    {
        public int? Key { get { return 2; } }
        public override void Do()
        {
            Sense sense = new Sense();
            sense.Cry();
        }
    }
}
