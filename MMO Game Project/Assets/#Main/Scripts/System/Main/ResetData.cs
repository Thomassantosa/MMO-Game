using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetData : MonoBehaviour
{
    public bool resetData;
    void Start()
    {
        if(resetData)
        Invoke(nameof(ResetAllData), 2);
    }

    private void ResetAllData()
    {

        PlayerPrefs.DeleteAll();
    }
}
