using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCQuest : Item
{
    public override void CanGetItem()
    {
        PlayerControl.Instance.tpc.SetItem(this);
    }
    public override void GetItem()
    {
        if (PlayerControl.Instance.tpc._input.isPickUp)
        {
            GameManager.Instance.canvasManager.ShowPanelQuest();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Show Interact

        if (other.transform.tag.Equals("Player"))
        {
            CanGetItem();
            canvasInteract.SetActive(true);
        }
    }
}
