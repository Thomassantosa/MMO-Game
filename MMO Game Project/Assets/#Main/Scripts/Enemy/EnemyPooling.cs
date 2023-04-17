using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPooling : MonoBehaviour
{
    public GameObject[] objectEnemies;
    //public Transform posRespawn;
    public float timeResawn;

    public int counterEnemyDie;

    public void EnemyDie()
    {/*
        counterEnemyDie++;
        if (counterEnemyDie >= 3)
            GameManager.Instance.questManager.FinishQuest1();*/
/*
        Invoke(nameof(RespawnEnemy), timeResawn);*/
    }
    public void RespawnEnemy()
    {
        foreach (GameObject enemy in objectEnemies)
        {
            if (!enemy.activeInHierarchy)
            {
                enemy.SetActive(true);
                //item.transform.position = posRespawn.position;
                enemy.GetComponent<EnemyControl>().InitEnemy();
                break;
            }
        }
    }
}
