using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject canvasInteract;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Show Interact

    }

    private void OnTriggerExit(Collider other)
    {
        //Hide Interact

    }

    virtual public void GetItem() { }
}

public enum ITEM
{
    GEAR
}
public enum GEAR
{ 
    BOOTS, CHEST, HELMET, PANTS
}

