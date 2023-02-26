using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveRight : MonoBehaviour
{
    public GameObject MainCamera;

    public GameObject CameraGoLeft;

    public bool CameraMove;

    public int CameraMoveValue = 6;

    private void OnTriggerEnter()
    {
        MainCamera.transform.Translate(CameraMoveValue, 0, 0);
        CameraMove = true;
        CameraGoLeft.SetActive(true);
        gameObject.SetActive(false);
    }
}
