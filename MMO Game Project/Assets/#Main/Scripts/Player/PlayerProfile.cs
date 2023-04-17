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
    public int armor;
    public int Armor
    {
        get { return armor; }
        set
        {
            armor = value;
            onArmorUpdate?.Invoke(armor);
        }

    }
    public Action<int> onArmorUpdate;

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

    private void Start()
    {
        LoadData();
    }
    public void LoadData()
    {
        if(!PlayerPrefs.HasKey("BOW"))
        {
            PlayerPrefs.SetInt("BOW", 0);
            PlayerPrefs.SetInt("BOOTS", 0);
            PlayerPrefs.SetInt("CHEST", 0);
            PlayerPrefs.SetInt("HELMET", 0);
            PlayerPrefs.SetInt("PANTS", 0);
        }

        hasBow = PlayerPrefs.GetInt("BOW") == 1 ? true : false;
        hasBoots = PlayerPrefs.GetInt("BOOTS") == 1 ? true : false;
        hasChest = PlayerPrefs.GetInt("CHEST") == 1 ? true : false;
        hasHelmet = PlayerPrefs.GetInt("HELMET") == 1 ? true : false;
        hasPants = PlayerPrefs.GetInt("PANTS") == 1 ? true : false;

        Armor = 0;
        if (hasPants)
        {
            Armor += 50;
        }
        if (hasChest)
        {
            Armor += 50;
        }
        RefreshGear();
    }

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
