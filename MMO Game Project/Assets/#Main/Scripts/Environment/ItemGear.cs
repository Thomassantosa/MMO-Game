using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGear : Item
{
    public GEAR gear;
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
            switch (gear)
            {
                case GEAR.BOOTS:
                    PlayerControl.Instance.profile.hasBoots = true;
                    PlayerPrefs.SetInt("BOOTS", 1);
                    break;
                case GEAR.CHEST:
                    PlayerControl.Instance.profile.hasChest = true;
                    PlayerControl.Instance.profile.Armor += 50;
                    PlayerPrefs.SetInt("CHEST", 1);
                    break;
                case GEAR.HELMET:
                    PlayerControl.Instance.profile.hasHelmet = true;
                    PlayerPrefs.SetInt("HELMET", 1);
                    break;
                case GEAR.PANTS:
                    PlayerControl.Instance.profile.hasPants = true;
                    PlayerControl.Instance.profile.Armor += 50;
                    PlayerPrefs.SetInt("PANTS", 1);
                    break;
                case GEAR.BOW:
                    PlayerControl.Instance.profile.hasBow = true;
                    PlayerPrefs.SetInt("BOW", 1);
                    break;
            }
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
