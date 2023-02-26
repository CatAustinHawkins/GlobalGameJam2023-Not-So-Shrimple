using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveUp : MonoBehaviour
{
    public GameObject MainCamera;

    public GameObject CameraGoDown;

    public bool CameraMove;

    public int CameraMoveValue = 6;

    private void OnTriggerEnter()
    {
        MainCamera.transform.Translate(0, CameraMoveValue, 0);
        CameraMove = true;
        CameraGoDown.SetActive(true);
        gameObject.SetActive(false);
    }

}
