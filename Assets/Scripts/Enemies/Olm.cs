using UnityEngine;

public class Olm : MonoBehaviour
{
    public GameObject Player;

    public Animator OlmAnim;

    public float timer;

    public bool timerbegin;

    public GameObject OlmDeadGO;

    public Sprite OlmAttack;
    public Sprite OlmNormal;

    public SpriteRenderer spriteRenderer;

    public void Start()
    {
        OlmAnim = gameObject.GetComponent<Animator>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if(timerbegin)
        {
            timer = timer + 1 * Time.deltaTime;
        }

        if (timer > 0.5f && timerbegin)
        {
            spriteRenderer.sprite = OlmNormal;
            OlmAnim.Play("OlmIdle");
            timerbegin = false;
            timer = 0f;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Player.GetComponent<PlayerMovement>().HealthDecrease();
        spriteRenderer.sprite = OlmAttack;
        timerbegin = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        OlmDeadGO.SetActive(true);
        gameObject.SetActive(false);
    }


}