using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using Cinemachine;

public class PlayerAttack : MonoBehaviour
{
    public CinemachineVirtualCamera aimVirtualCam;
    public PlayerControl controller;

    public bool shootBullet;

    public GameObject bulletPrefab;
    public Transform spawnPoint;
    public float shootForce = 50f;
    public float shootDelay;
    public LayerMask aimColliderMask = new LayerMask();


    public float normalSensitivity;
    public float aimSensitivity;
    private void Update()
    {
        Vector3 mouseWorldPos = Vector3.zero;

        Vector2 screenCenter = new Vector2(Screen.width / 2f, Screen.height / 2f);
        Ray ray = Camera.main.ScreenPointToRay(screenCenter);
        Transform hitTransform = null;
        if (Physics.Raycast(ray, out RaycastHit hit, 999f, aimColliderMask))
        {
            mouseWorldPos = hit.point;
            hitTransform = hit.transform;
        }

        if (controller.starterAssetsInputs.isAim)
        {
            aimVirtualCam.gameObject.SetActive(true);
            controller.tpc.rotateOnMove = false;
            controller.tpc.sensitivity = aimSensitivity;


            Vector3 worldAimTarget = mouseWorldPos;
            worldAimTarget.y = transform.position.y;
            Vector3 aimDirection = (worldAimTarget - transform.position).normalized;

            transform.forward = Vector3.Lerp(transform.forward, aimDirection, Time.deltaTime * 20f);
        }
        else
        {
            aimVirtualCam.gameObject.SetActive(false);
            controller.tpc.rotateOnMove = true;
            controller.tpc.sensitivity = normalSensitivity;
        }

        if (shootBullet && controller.profile.hasBow)
        {
            if(hitTransform != null)
            {
                //Munculin panah disitu
            }
            Vector3 aimDir = (mouseWorldPos - spawnPoint.position).normalized;
            Instantiate(bulletPrefab, spawnPoint.position, Quaternion.LookRotation(aimDir.normalized, Vector3.up));
            shootBullet = false;
            controller.starterAssetsInputs.isAttack = false;
        }
    }

    private void Shoot()
    {

    }

}
