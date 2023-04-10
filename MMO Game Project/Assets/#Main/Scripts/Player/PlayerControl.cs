using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
public class PlayerControl : MonoBehaviour
{
    public static PlayerControl Instance;


    public StarterAssetsInputs starterAssetsInputs;
    public ThirdPersonController tpc;
    public PlayerProfile profile;
    public PlayerAttack attack;


    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        
    }

    void Update()
    {

    }
    public void Attack()
    {
        tpc.ShootBow();
        Invoke(nameof(ShootArrow), attack.shootDelay);
        starterAssetsInputs.isAttack = false;
    }
    public void ShootArrow()
    {
        attack.shootBullet = true;
    }

    public void GetDamage(int dmg)
    {
        if (profile.isImmune) return;

        int currentHealth = profile.Health;
        currentHealth -= dmg;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            //Player Die
        }

        profile.SetHealth(currentHealth);

        SoundManager.Instance.PlaySFX(SFX.GET_DAMAGE);
    }
}
