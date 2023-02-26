using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveDown : MonoBehaviour
{
    public GameObject MainCamera;

    public GameObject CameraGoUp;

    public int CameraMoveValue = -6;
    private void OnTriggerEnter()
    {
        MainCamera.transform.Translate(0, CameraMoveValue, 0);
        CameraGoUp.SetActive(true);
        gameObject.SetActive(false);
    }
}
