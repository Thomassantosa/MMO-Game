using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemJamur : Item
{
    public override void CanGetItem()
    {
        PlayerControl.Instance.tpc.SetItem(this);
    }
    public override void GetItem()
    {
        if (PlayerControl.Instance.tpc._input.isPickUp)
        {
            Instantiate(effectPick, posEffectPick.position, Quaternion.identity);
            PlayerControl.Instance.tpc.ReleaseItem();
            //Increment Jamur Counter
            //GameManager.Instance.questManager.IncrementJamur();
            Invoke(nameof(ApplyItem), .35f);
        }
    }

    private void ApplyItem()
    {
        PlayerControl.Instance.profile.RefreshGear();
        Destroy(gameObject, .025f);
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
