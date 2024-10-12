using UnityEngine;

public class CameraGoLeft : MonoBehaviour
{
    public GameObject MainCamera;

    public GameObject CameraGoRight;

    public bool CameraMove;

    public int CameraMoveValue = -6;

    private void OnTriggerEnter()
    {
        MainCamera.transform.Translate(CameraMoveValue, 0, 0);
        CameraMove = true;
        CameraGoRight.SetActive(true);
        gameObject.SetActive(false);
    }
}
