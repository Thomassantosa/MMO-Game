using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishingQuest : MonoBehaviour
{
    public int questNumber;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            if(questNumber == 1)
            {
                GameManager.Instance.questManager.FinishQuest1();
            }
            else
            {

                GameManager.Instance.questManager.FinishQuest2();
                GameManager.Instance.EndGame();
            }

            Destroy(gameObject, 0.5f);
        }
    }
}
