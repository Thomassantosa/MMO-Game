using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CanvasManager : MonoBehaviour
{
    public Slider sliderHealth;
    public TextMeshProUGUI textHealth;

    public Slider sliderArmor;
    public TextMeshProUGUI textArmor;

    public GameObject panelQuest;
    void Start()
    {

    }

    void Update()
    {
        
    }

    public void UpdateSliderHealth(int val)
    {
        sliderHealth.value = val;
        textHealth.text = $"{val}";
    }
    public void UpdateSliderArmor(int val)
    {
        sliderArmor.value = val;
        textArmor.text = $"{val}";
    }
    public void ShowPanelQuest()
    {
        GameManager.Instance.playerControl.tpc.LockCameraPosition = true;
        panelQuest.SetActive(true);
    }
    public void HidePanelQuest()
    {
        GameManager.Instance.playerControl.tpc.LockCameraPosition = false;
        panelQuest.SetActive(false);
    }

}
