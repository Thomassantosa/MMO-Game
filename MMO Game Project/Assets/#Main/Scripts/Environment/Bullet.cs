using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject effectHit;
    public GameObject effectHitEnemy;
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
        if (other.gameObject.tag == "EnemyDamage")
        {
            Instantiate(effectHitEnemy, transform.position, transform.rotation);
            Debug.Log("Dmg");
            other.GetComponent<EnemyControl>().GetDamage(bulletDamage);
            Destroy(gameObject, .1f);
        }
        else
        {
            Instantiate(effectHit, transform.position, transform.rotation);
            rB.isKinematic = true;
            GetComponent<BoxCollider>().enabled = false;
            enabled = false;
        }

    }
}
