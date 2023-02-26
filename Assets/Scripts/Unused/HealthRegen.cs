using UnityEngine;

public class HealthRegen : MonoBehaviour
{
    public GameObject Player;

    private void OnCollisionEnter(Collision collision)
    {
        //Player.GetComponent<PlayerMovement>().HealthIncrease();
        Destroy(gameObject);
    }
}
