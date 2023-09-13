using UnityEngine.UI;
using UnityEngine;

public class SwitchOfImage : MonoBehaviour
{
    public void HideImage()
    {
        GetComponent<Image>().enabled = false;
    }
}
