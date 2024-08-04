using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IDropHandler
{
    public GameObject ConeRespawn;


    public void OnDrop(PointerEventData eventData)
    {
        ConeRespawn = GameObject.Find("Cone");

        if (transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag;
            DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();
            draggableItem.Parentafterdrag = transform;
            Instantiate(ConeRespawn, transform.position, quaternion.identity);
        }
    }

    // Start is called before the first frame update

}
