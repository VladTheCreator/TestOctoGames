using Naninovel;

[CommandAlias("continueScriptPlayer")]
public class ContinueScriptPlayer : Command
{
    [ParameterAlias("reset")]
    public BooleanParameter ResetState = false;
    public override async UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        //1.Continue script player.
        var scriptPlayer = Engine.GetService<IScriptPlayer>();
        scriptPlayer.Play();
        //2. Reset state (if required).
        if (ResetState)
        {
            var stateManager = Engine.GetService<IStateManager>();
            await stateManager.ResetStateAsync();
        }
    }
}
