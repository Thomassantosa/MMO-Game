using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Item : MonoBehaviour
{

    public GameObject canvasInteract;
    public TextMeshProUGUI textItemName;

    public string itemName;

    void Start()
    {
        textItemName.text = itemName;
    }

    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        //Hide Interact

        if (other.transform.tag.Equals("Player"))
        {
            PlayerControl.Instance.tpc.currentItem = null;
            canvasInteract.SetActive(false);
        }
    }

    virtual public void CanGetItem() { }
    virtual public void GetItem() { }
}

public enum ITEM
{
    GEAR
}
public enum GEAR
{ 
    BOOTS, CHEST, HELMET, PANTS, BOW
}

