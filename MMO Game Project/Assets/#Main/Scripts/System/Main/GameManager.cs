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

    public GameObject panelTransisi;
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

    public void EndGame()
    {
        Invoke(nameof(TransisiCredit), 3f);
    }

    private void TransisiCredit()
    {
        GameManager.Instance.playerControl.tpc.LockCameraPosition = true;

        GameManager.Instance.playerControl.tpc.MoveSpeed = 0;
        panelTransisi.SetActive(true);
    }
}
