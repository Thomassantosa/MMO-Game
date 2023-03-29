using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGear : Item
{
    public GEAR gear;

    public override void CanGetItem()
    {
        PlayerControl.Instance.tpc.currentItem = this;
    }
    public override void GetItem()
    {
        if (PlayerControl.Instance.tpc._input.isPickUp)
        {
            switch (gear)
            {
                case GEAR.BOOTS:
                    PlayerControl.Instance.profile.hasBoots = true;
                    break;
                case GEAR.CHEST:
                    PlayerControl.Instance.profile.hasChest = true;
                    break;
                case GEAR.HELMET:
                    PlayerControl.Instance.profile.hasHelmet = true;
                    break;
                case GEAR.PANTS:
                    PlayerControl.Instance.profile.hasPants = true;
                    break;
            }
            Invoke(nameof(ApplyItem), .35f);
        }
    }

    private void ApplyItem()
    {
        PlayerControl.Instance.profile.RefreshGear();
        PlayerControl.Instance.tpc.currentItem = null;
        Destroy(gameObject, .025f);
    }
}
