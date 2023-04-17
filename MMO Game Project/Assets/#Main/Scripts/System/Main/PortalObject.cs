using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalObject : MonoBehaviour
{
    public GameObject objectEffect;
    public string nameScene;

    private void OnTriggerEnter(Collider other)
    {
        //Show Interact

        if (other.transform.tag.Equals("Player"))
        {
            objectEffect.SetActive(true);
            Invoke(nameof(ChangeScene), 3);
        }
    }

    private void ChangeScene()
    {
        SceneManagement.Instance.ChangeScene(nameScene);
    }
}

