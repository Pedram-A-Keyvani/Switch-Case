namespace SwitchCase_State
{
    public interface ICase<TCase>
    {
        TCase Key { get; }
    }
}
