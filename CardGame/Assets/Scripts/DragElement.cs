using UnityEngine;
using UnityEngine.EventSystems;

public class DragElement : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public  Transform _parentReturn = null;
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
        _parentReturn = this.transform.parent;
        this.transform.SetParent(transform.parent.root);

        // Toggle raycast blocking off
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
        this.transform.SetParent(_parentReturn);

        // Toggle raycast blocking on
        GetComponent<CanvasGroup>().blocksRaycasts = true;

    }

}
