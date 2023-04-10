using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPooling : MonoBehaviour
{
    public GameObject[] objectEnemies;
    //public Transform posRespawn;
    public float timeResawn;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void EnemyDie()
    {
        Invoke(nameof(RespawnEnemy), timeResawn);
    }
    public void RespawnEnemy()
    {
        foreach (GameObject item in objectEnemies)
        {
            if (!item.activeInHierarchy)
            {
                item.SetActive(true);
                //item.transform.position = posRespawn.position;
                item.GetComponent<EnemyControl>().InitEnemy();
                break;
            }
        }
    }
}
