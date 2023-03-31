using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProfile : MonoBehaviour
{

    public bool hasBoots;
    public bool hasChest;
    public bool hasHelmet;
    public bool hasPants;
    public bool hasBow;
    public GameObject objBoots;
    public GameObject objChest;
    public GameObject objHelmet;
    public GameObject objPants;
    public GameObject objBow;


    public GameObject effectRefreshGear;
    public void RefreshGear()
    {
        objBoots.SetActive(hasBoots);
        objChest.SetActive(hasChest);
        objHelmet.SetActive(hasHelmet);
        objPants.SetActive(hasPants);
        objBow.SetActive(hasBow);
        effectRefreshGear.SetActive(true);
    }
}
