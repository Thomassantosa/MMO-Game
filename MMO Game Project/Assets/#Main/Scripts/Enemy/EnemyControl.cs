using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public int health;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void GetDamage(int dmg)
    {
        health -= dmg;
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
