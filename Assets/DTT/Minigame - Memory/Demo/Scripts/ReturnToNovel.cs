using Naninovel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToNovel : MonoBehaviour
{
    public string ScriptName;
    public string Label;
    public void BackToNovel()
    {
        //1. Disable UI for minigame
        var levelSelect = FindObjectOfType<LevelSelectHolder>();
        levelSelect.HideLevelSelect();

        var canvas = FindObjectOfType<MainCanvas>();
        canvas.HideCanvas();

        //2. Stop playing minigame theme
        var mainTheme = FindObjectOfType<MainThemeManager>();
        mainTheme.Stop();

        var inputManager = Engine.GetService<IInputManager>();
        inputManager.ProcessInput = true;

        var scriptPlayer = Engine.GetService<IScriptPlayer>();
        scriptPlayer.PreloadAndPlayAsync(ScriptName, label: Label).Forget();

       
    }
}
