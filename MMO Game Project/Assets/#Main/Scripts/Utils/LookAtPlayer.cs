using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public Camera cam;

    private void Start()
    {
        if(cam == null)
        {
            cam = GameManager.Instance.mainCamera;
        }
    }
    private void OnEnable()
    {
        if (cam == null)
        {
            cam = GameManager.Instance.mainCamera;
        }
    }
    void Update()
    {
        if (cam == null) return;

        transform.LookAt(transform.position + cam.transform.rotation * Vector3.forward,
        cam.transform.rotation * Vector3.up);
    }
}
