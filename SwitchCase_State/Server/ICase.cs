namespace SwitchCase_State.Server
{
    public interface ICase<TCase>
    {
        TCase Key { get; }
    }
}
