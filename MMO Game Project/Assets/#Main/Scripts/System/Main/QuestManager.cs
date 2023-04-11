using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class QuestManager : MonoBehaviour
{

    public TextMeshProUGUI textQuest;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void GetQuest()
    {
        textQuest.text = "Save Citizens";
        textQuest.color = Color.red;
    }
    public void FinishQuest()
    {
        textQuest.text = "Save Citizens (Done)";
        textQuest.color = Color.green;
    }
}
