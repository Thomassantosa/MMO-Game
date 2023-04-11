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
    {
        counterEnemyDie++;
        if (counterEnemyDie >= 3)
            GameManager.Instance.questManager.FinishQuest();

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
