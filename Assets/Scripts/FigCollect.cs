using UnityEngine;
using UnityEngine.SceneManagement;

public class FigCollect : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("WinScreen");
    }

}
