using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class DropHandler : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        GameObject inventoryObject = eventData.pointerDrag;



        if (inventoryObject.transform.GetChild(0).GetComponent<TMP_Text>().text == "V")
        {

            if (transform.childCount == 0)
            {
                GameObject cloned = Instantiate(inventoryObject, transform);
                Destroy(cloned.GetComponent<Drag>());
                cloned.GetComponent<Image>().raycastTarget = false;
                Destroy(cloned.transform.GetChild(0).gameObject);
            }
            else
            {
                Debug.Log("The slot is already occupied");
            }
        }
        else if (inventoryObject.transform.GetChild(0).GetComponent<TMP_Text>().text == "S")
        {
            Destroy(transform.GetChild(0).gameObject);
        }





        // else
        // {
        //     if (transform.childCount != 0)
        //     {
        //         Destroy(transform.GetChild(0).gameObject);
        //     }
        //     else
        //     {
        //         Debug.Log("Nothing is here");
        //     }

    }
}
