using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetData : MonoBehaviour
{
    public bool resetData;
    private void Awake()
    {

        if (resetData)
            PlayerPrefs.DeleteAll();
    }
/*    void Start()
    {
        if(resetData)
        Invoke(nameof(ResetAllData), 2);
    }*/

    private void ResetAllData()
    {

        PlayerPrefs.DeleteAll();
    }
}
