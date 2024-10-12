using UnityEngine;

public class CameraTriggerUp : MonoBehaviour
{
    public GameObject Camera;

    private void OnTriggerEnter(Collider other)
    {
        Camera.GetComponent<CameraMove>().GoingUp();
    }
}
