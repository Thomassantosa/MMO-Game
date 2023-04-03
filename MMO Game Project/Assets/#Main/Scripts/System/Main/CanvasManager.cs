using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CanvasManager : MonoBehaviour
{
    public Slider sliderHealth;
    public TextMeshProUGUI textHealth;

    void Start()
    {

    }

    void Update()
    {
        
    }

    public void UpdateSliderHealth(int val)
    {
        sliderHealth.value = val;
        textHealth.text = $"Health : {val}";
    }
}
