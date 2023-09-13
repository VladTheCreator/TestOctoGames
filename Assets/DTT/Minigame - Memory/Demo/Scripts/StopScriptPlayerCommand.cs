using Naninovel;

[CommandAlias("stopScriptPlayer")]
public class StopScriptPlayerCommand : Command
{
    [ParameterAlias("reset")]
    public BooleanParameter ResetState = false;
    public override async UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        //1.Stop script player.
        var scriptPlayer = Engine.GetService<IScriptPlayer>();
        scriptPlayer.Stop();
        //2. Reset state (if required).
        if (ResetState)
        {
            var stateManager = Engine.GetService<IStateManager>();
            await stateManager.ResetStateAsync();
        }
    }
}
