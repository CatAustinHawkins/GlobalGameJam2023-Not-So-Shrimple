using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public GameObject Camera;

    private void OnTriggerEnter(Collider other)
    {
        Camera.GetComponent<CameraMove>().GoingSideways();
    }
}
