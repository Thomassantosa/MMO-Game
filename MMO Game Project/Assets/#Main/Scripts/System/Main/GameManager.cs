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
        }
    }
    void Start()
    {
        //Subscribe
        playerControl.profile.onHealthUpdate += canvasManager.UpdateSliderHealth;
        playerControl.profile.onArmorUpdate += canvasManager.UpdateSliderArmor;


        playerControl.profile.SetHealth(100);
    }

    void Update()
    {
        
    }
}
