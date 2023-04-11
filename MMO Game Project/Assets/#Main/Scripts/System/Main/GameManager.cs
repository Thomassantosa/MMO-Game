using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public PlayerControl playerControl;
    public CanvasManager canvasManager;
    public Camera mainCamera;

    public QuestManager questManager;
    public EnemyPooling enemyPooling;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        //Subscribe
        playerControl.profile.onHealthUpdate += canvasManager.UpdateSliderHealth;


        playerControl.profile.SetHealth(100);
    }

    void Update()
    {
        
    }
}
