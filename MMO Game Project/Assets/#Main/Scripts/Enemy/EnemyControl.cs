using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public int health;

    public Animator anim;
    public GameObject effectHide;

    public float timeHide;

    public Transform player;
    public float speed;
    private bool die;
    void Update()
    {
        if (die) return;

        if (player != null)
        {
            anim.SetBool("WalkForward", true);
            transform.LookAt(player.position);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag.Equals("Player"))
        {
            player = other.transform;
        }
    }
    public void GetDamage(int dmg)
    {
        if (health <= 0) return;

        health -= dmg;
        if(health <= 0)
        {
            die = true;
            anim.SetBool("WalkForward", false);
            anim.SetBool("Death", true);
            //GameManager.Instance.enemyPooling.EnemyDie();
            Invoke(nameof(HideEnemy), timeHide);
        }
    }
    public void HideEnemy()
    {
        Instantiate(effectHide, transform.position, transform.rotation);
        gameObject.SetActive(false);
    }
    
    public void InitEnemy()
    {
        health = 100;
        anim.SetBool("Death", false);

    }
}
