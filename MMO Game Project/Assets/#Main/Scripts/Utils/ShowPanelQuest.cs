using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPanelQuest : MonoBehaviour
{
    public GameObject panelQuest;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            panelQuest.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            panelQuest.SetActive(false);
        }
    }
}
