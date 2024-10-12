using UnityEngine;

public class Spikes : MonoBehaviour
{
    public GameObject Player;

    private void OnCollisionEnter(Collision collision)
    {
        Player.GetComponent<PlayerMovement>().HealthDecrease();
    }
}
