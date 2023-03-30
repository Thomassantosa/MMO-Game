using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemChest : Item
{
    public bool hasOpen;
    public GameObject[] items;
    public override void CanGetItem()
    {
        PlayerControl.Instance.tpc.SetItem(this);
    }
    public override void GetItem()
    {
        if (hasOpen) return;

        if (PlayerControl.Instance.tpc._input.isPickUp)
        {
            OpenChest();
            //Invoke(nameof(ApplyItem), .25f);
        }
    }
    private void OpenChest()
    {
        hasOpen = true;
        PlayerControl.Instance.tpc.ReleaseItem();

        foreach (GameObject item in items)
        {
            item.SetActive(true);
        }
        canvasInteract.SetActive(false);
        this.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (hasOpen) return;

        if (other.transform.tag.Equals("Player"))
        {
            CanGetItem();
            canvasInteract.SetActive(true);
        }
    }
}
