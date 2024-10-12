using UnityEngine;

public class Frog : MonoBehaviour
{
    public GameObject Player;

    public Animator FrogAnim;

    public float timer;

    public bool timerbegin;

    public GameObject FrogDeadGO;

    public Sprite FrogAttack;
    public Sprite FrogNormal;

    public SpriteRenderer spriteRenderer;

    public void Start()
    {
        FrogAnim = gameObject.GetComponent<Animator>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (timerbegin)
        {
            timer = timer + 1 * Time.deltaTime;
        }

        if (timer > 0.5f && timerbegin)
        {
            spriteRenderer.sprite = FrogNormal;
            FrogAnim.Play("FrogIdle");
            timerbegin = false;
            timer = 0f;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Player.GetComponent<PlayerMovement>().HealthDecrease();
        spriteRenderer.sprite = FrogAttack;
        timerbegin = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        FrogDeadGO.SetActive(true);
        gameObject.SetActive(false);
    }
}
