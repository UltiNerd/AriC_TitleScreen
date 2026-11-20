using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonShrink : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Vector3 originalScale;

    private void Start()
    {
        originalScale = transform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        UnityEngine.Debug.Log("enter");
        transform.localScale = originalScale * 0.9f; // Shrink to 90%
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        UnityEngine.Debug.Log("exit");
        transform.localScale = originalScale;
    }

}
