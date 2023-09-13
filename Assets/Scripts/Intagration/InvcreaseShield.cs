using System.Collections;
using UnityEngine;

public class InvcreaseShield : MonoBehaviour
{
    [SerializeField] private float maxSize;
    [SerializeField] private float growSpeed;
    private RectTransform rectTransform;
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        StartCoroutine(PresentShield());
    }
    private IEnumerator PresentShield()
    {
        while (rectTransform.sizeDelta.x < maxSize)
        {
            rectTransform.sizeDelta += new Vector2(Time.deltaTime * growSpeed, Time.deltaTime * growSpeed);
            yield return null;
        }
    }
}
