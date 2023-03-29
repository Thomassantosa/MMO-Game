using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
public class PlayerControl : MonoBehaviour
{
    public static PlayerControl Instance;

    public ThirdPersonController tpc;
    public PlayerProfile profile;


    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
