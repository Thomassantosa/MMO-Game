using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDialog : MonoBehaviour
{
    public GameObject panelDialog;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            panelDialog.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            panelDialog.SetActive(false);
        }
    }
}
