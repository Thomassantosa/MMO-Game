using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject effectHit;
    private Rigidbody rB;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private int bulletDamage;

    private void Awake()
    {
        rB = GetComponent<Rigidbody>();
    }
    void Start()
    {
        rB.velocity = transform.forward * bulletSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "EnemyDamage")
        {
            Debug.Log("Dmg");
            other.GetComponent<EnemyControl>().GetDamage(bulletDamage);
        }

        Instantiate(effectHit, transform.position, transform.rotation);
        Destroy(gameObject,.1f);
    }
}
