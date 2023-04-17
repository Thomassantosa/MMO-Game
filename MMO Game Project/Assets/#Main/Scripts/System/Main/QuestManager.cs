using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{

    public TextMeshProUGUI textQuest;

    public TextMeshProUGUI textButton1;
    public Button buttonQuest1;
    public TextMeshProUGUI textButton2;
    public Button buttonQuest2;

    public int questProgress1;
    public int questProgress2;
    public int questDone1;
    public int questDone2;

    [SerializeField] private int jamurTarget;
    [SerializeField] private int jamurCount;
    
    void Start()
    {
        questProgress1 = PlayerPrefs.GetInt("PROGRESS1");
        questProgress2 = PlayerPrefs.GetInt("PROGRESS2");
        questDone1 = PlayerPrefs.GetInt("QUEST1");
        questDone2 = PlayerPrefs.GetInt("QUEST2");

        if(questProgress1 == 1)
        {
            GetQuest1();
        }
        if(questDone1 == 1)
        {
            FinishQuest1();
        }
        if (questProgress2 == 1)
        {
            GetQuest2();
        }
        if (questDone2 == 1)
        {
            FinishQuest2();
        }
    }

    void Update()
    {
        
    }

    public void GetQuest1()
    {
        PlayerPrefs.SetInt("PROGRESS1", 1);
        textQuest.text = "Collect Mushroom";
        textQuest.color = Color.red;
        textButton1.text = "On Progress";
        buttonQuest1.interactable = false;
    }
    public void FinishQuest1()
    {
        questDone1 = 1;
        PlayerPrefs.SetInt("QUEST1", 1);
        textQuest.text = "Collect Mushroom (Done)";
        textQuest.color = Color.green;
        buttonQuest2.interactable = true;
        textButton1.text = "Done";
    }

    public void GetQuest2()
    {
        PlayerPrefs.SetInt("PROGRESS2", 1);
        textQuest.text = "Save Citizens";
        textQuest.color = Color.red;
        textButton2.text = "On Progress";
        buttonQuest2.interactable = false;
    }
    public void FinishQuest2()
    {
        questDone2 = 1;
        PlayerPrefs.SetInt("QUEST2", 1);
        textQuest.text = "Save Citizens (Done)";
        textQuest.color = Color.green;
        textButton2.text = "Done";
    }

/*    public void IncrementJamur()
    {
        jamurCount++;

        if(jamurCount >= jamurTarget)
        {
            FinishQuest1();
        }
    }*/

}
