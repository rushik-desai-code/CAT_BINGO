using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Drag : MonoBehaviour
{
    [SerializeField]

    private Canvas canvas;
    public GameObject fruit;

    public void DragHandler(BaseEventData data)
    {
        PointerEventData pointerData = (PointerEventData)data;

        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            (RectTransform)canvas.transform,
             pointerData.position,
            canvas.worldCamera,
            out position);

        transform.position = canvas.transform.TransformPoint(position);
        Debug.Log(transform.position);
        if (transform.position.x > 1250 && transform.position.x < 1400 && transform.position.y > 220 && transform.position.y < 300)
        {
            fruit.SetActive(false);
        }
    }
}