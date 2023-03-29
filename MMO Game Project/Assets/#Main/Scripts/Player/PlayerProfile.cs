using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProfile : MonoBehaviour
{

    public bool hasBoots;
    public bool hasChest;
    public bool hasHelmet;
    public bool hasPants;
    public GameObject objBoots;
    public GameObject objChest;
    public GameObject objHelmet;
    public GameObject objPants;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void RefreshGear()
    {
        objBoots.SetActive(hasBoots);
        objChest.SetActive(hasChest);
        objHelmet.SetActive(hasHelmet);
        objPants.SetActive(hasPants);
    }
}
