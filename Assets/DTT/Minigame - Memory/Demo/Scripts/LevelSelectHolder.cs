using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectHolder : MonoBehaviour
{
    public void HideLevelSelect()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }
    public void ShowLevelSelect()
    {
        transform.GetChild(0).gameObject.SetActive(true);
    }
}
