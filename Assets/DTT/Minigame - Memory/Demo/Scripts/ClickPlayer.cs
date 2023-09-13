using UnityEngine;

public class ClickPlayer : MonoBehaviour
{
    public void PlayerClick()
    {
        GetComponent<AudioSource>().Play();
    }
}
