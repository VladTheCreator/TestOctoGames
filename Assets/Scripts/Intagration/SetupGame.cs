using Naninovel;
using UnityEngine;

public class SetupGame : MonoBehaviour
{
    private async void Start()
    {
        // 1. Initialize Naninovel.
        await RuntimeInitializer.InitializeAsync();
        //var stateManager = Engine.GetService<IStateManager>();
        //await stateManager.ResetStateAsync();
        if (Engine.Initialized) DoMyCustomWork();
        else Engine.OnInitializationFinished += DoMyCustomWork;
    }
    private async void DoMyCustomWork()
    {
        //// Engine is initialized here, it's safe to use the APIs.
        //var scriptPlayer = Engine.GetService<IScriptPlayer>();
        //await scriptPlayer.PreloadAndPlayAsync("Intro");
    }
}
