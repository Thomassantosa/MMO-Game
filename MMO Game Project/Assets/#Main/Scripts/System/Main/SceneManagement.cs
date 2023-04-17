using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{
    public static SceneManagement Instance;


    public GameObject panelLoading;
    public Slider sliderLoading;
    public TextMeshProUGUI textLoading;

    public float timeLoading;
    public float timeAsync = 0.9f;
    private string sceneName;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void ChangeScene(string name)
    {
        sceneName = name;
        panelLoading.SetActive(true);
        Invoke(nameof(ProcesssScene), 3);
    }
    private void ProcesssScene()
    {
        StartCoroutine(LoadAsynchronously());
    }

    IEnumerator LoadAsynchronously()
    {

        AsyncOperation opt = SceneManager.LoadSceneAsync(sceneName);
        while (!opt.isDone)
        {
            float progress = Mathf.Clamp01(opt.progress / timeAsync);

            int val = (int)(progress * 100);
            sliderLoading.value = val;
            textLoading.text = val + "%";

            yield return null;
        }
    }
}
