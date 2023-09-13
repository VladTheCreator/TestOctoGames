using Naninovel;
using UnityEngine;

public class GotoMap : MonoBehaviour
{
    public string ScriptName;
    public string Label;
    public void ReturnToTheMap()
    {
        //2.Stop script player.
        var scriptPlayer = Engine.GetService<IScriptPlayer>();
        scriptPlayer.Stop();

        //Go to map UI
        scriptPlayer.PreloadAndPlayAsync(ScriptName, label: Label).Forget();
    }
}
