using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    public PlayerControl controller;

    private void OnCollisionEnter(Collision collision)
    {
/*        if (collision.gameObject.tag.Equals("EnemyDamage"))
        {
            //Ganti Dengan Damage Enemy
            int tempDamage = 10;

            controller.GetDamage(tempDamage);
        }*/
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("EnemyDamage"))
        {
            //Ganti Dengan Damage Enemy
            int tempDamage = 10;

            controller.GetDamage(tempDamage);
        }
    }
}
