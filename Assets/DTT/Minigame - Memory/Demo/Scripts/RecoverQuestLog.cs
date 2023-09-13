using Naninovel;

[CommandAlias("recoverQuestLog")]
public class RecoverQuestLog : Command
{
    [ParameterAlias("reset")]
    public BooleanParameter ResetState = false;
    public override async UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        //1.Enable texts.
        var ui = Engine.GetService<UIManager>();
        //foreach(var item in ui.GetManagedUIs())
        //{
        //    if(item.)
        //}
        //2. Reset state (if required).
        if (ResetState)
        {
            var stateManager = Engine.GetService<IStateManager>();
            await stateManager.ResetStateAsync();
        }
    }
}
