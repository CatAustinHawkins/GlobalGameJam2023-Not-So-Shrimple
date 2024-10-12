using UnityEngine;

public class Terry : MonoBehaviour
{
    public GameObject Player;

    private void OnCollisionEnter(Collision collision)
    {
        Player.GetComponent<PlayerMovement>().TerryCollect();
        Destroy(gameObject);
    }
}
