using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemChest : Item
{
    public bool hasOpen;
    public GameObject[] items;
    public Animator anim;
    public GameObject effectItem;
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
        anim.SetBool("IsOpen", true);
        hasOpen = true;
        PlayerControl.Instance.tpc.ReleaseItem();
        Instantiate(effectPick, posEffectPick.position, Quaternion.identity);

        canvasInteract.SetActive(false);
        Invoke(nameof(SpawnItem), 1);
    }
    private void SpawnItem()
    {
        foreach (GameObject item in items)
        {
            item.SetActive(true);
            Instantiate(effectItem, item.transform.position, Quaternion.identity);
        }
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
