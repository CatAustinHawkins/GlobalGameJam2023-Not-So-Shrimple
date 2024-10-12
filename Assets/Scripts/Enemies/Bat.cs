using UnityEngine;

public class Bat : MonoBehaviour
{
    public GameObject Player;

    public Animator BatAnim;

    public float timer;

    public bool timerbegin;

    public GameObject BatDeadGO;

    public Sprite BatAttack;
    public Sprite BatNormal;

    public SpriteRenderer spriteRenderer;

    public void Start()
    {
        BatAnim = gameObject.GetComponent<Animator>();
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
            spriteRenderer.sprite = BatNormal;
            BatAnim.Play("BatIdle");
            timerbegin = false;
            timer = 0f;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Player.GetComponent<PlayerMovement>().HealthDecrease();
        spriteRenderer.sprite = BatAttack;
        timerbegin = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        BatDeadGO.SetActive(true);
        gameObject.SetActive(false);
    }
}
