using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public float timer;

    void Update()
    {
        timer = timer + 1 * Time.deltaTime;
        if(timer > 1f)
        {
            Destroy(gameObject);
        }
    }
}
