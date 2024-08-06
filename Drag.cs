using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private GameObject Movable;
    private Image MovableImage;
    public void OnBeginDrag(PointerEventData eventData)
    {

        Movable = Instantiate(gameObject, transform.position, transform.rotation, transform.root).gameObject;
        Destroy(Movable.transform.GetChild(0).gameObject);
        Vector2 size = gameObject.GetComponent<RectTransform>().sizeDelta;
        Movable.transform.SetAsLastSibling();
        MovableImage = Movable.GetComponent<Image>();
        MovableImage.color = new Color(MovableImage.color.r, MovableImage.color.g, MovableImage.color.b, 0.5f);
        MovableImage.raycastTarget = false;
        Movable.GetComponent<RectTransform>().sizeDelta = size;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Movable.GetComponent<RectTransform>().position = Input.mousePosition;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Destroy(Movable);
    }
}
