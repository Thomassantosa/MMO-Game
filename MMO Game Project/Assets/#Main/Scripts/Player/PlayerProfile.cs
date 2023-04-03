using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProfile : MonoBehaviour
{
    [Header("Core")]
    public int health;
    public int Health
    {
        get { return health; }
        private set{
            health = value;
            onHealthUpdate?.Invoke(health);
        }

    }
    public Action<int> onHealthUpdate;

    public bool isImmune;
    [SerializeField] private float immuneTime;
    private float _immuneTime;


    [Header("Gear")]
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

    public void SetHealth(int val)
    {
        Health = val;
    }

    private void Update()
    {
        if(isImmune)
        {
            _immuneTime -= Time.deltaTime;
            if(_immuneTime <= 0 )
            {
                isImmune = false;
                _immuneTime = 0;
            }
        }
    }
}
