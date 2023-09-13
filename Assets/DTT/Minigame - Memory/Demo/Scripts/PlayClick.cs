using Naninovel.Commands;
using Naninovel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Naninovel.Command;

[CommandAlias("clickSound")]
public class PlayClick : Command
{
    [ParameterAlias("reset")]
    public BooleanParameter ResetState = false;

    public override async UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        // 1. Reset state (if required).
        if (ResetState)
        {
            var stateManager = Engine.GetService<IStateManager>();
            await stateManager.ResetStateAsync();
        }
        //2. Play click    
        var clickPlayer = Object.FindObjectOfType<ClickPlayer>();
        clickPlayer.PlayerClick();
    }
}
