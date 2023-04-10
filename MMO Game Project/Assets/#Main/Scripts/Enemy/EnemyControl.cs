using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public int health;

    public Animator anim;
    public float timeHide;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void GetDamage(int dmg)
    {
        if (health <= 0) return;

        health -= dmg;
        if(health <= 0)
        {
            anim.SetBool("Death", true);
            GameManager.Instance.enemyPooling.EnemyDie();
            Invoke(nameof(HideEnemy), timeHide);
        }
    }
    public void HideEnemy()
    {
        gameObject.SetActive(false);
    }
    
    public void InitEnemy()
    {
        health = 100;
        anim.SetBool("Death", false);

    }
}
