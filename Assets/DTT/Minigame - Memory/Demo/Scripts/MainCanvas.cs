using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class MainCanvas : MonoBehaviour
{
    public void HideCanvas()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }
    public void ShowCanvas()
    {
        transform.GetChild(0).gameObject.SetActive(true);
    }
}
