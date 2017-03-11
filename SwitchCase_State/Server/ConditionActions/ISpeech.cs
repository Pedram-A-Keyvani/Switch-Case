namespace SwitchCase_State.Server.ConditionActions
{
    public interface ISpeech<TSpeech>
    {
        void Say(string message, TSpeech greeting);
    }
}
