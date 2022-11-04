using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropArea : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(eventData + " dropped");
        DragElement d = eventData.pointerDrag.GetComponent<DragElement>();

        if (d != null)
        {
            d._parentReturn = this.transform;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Entering area");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Leaving area");
    }
}
