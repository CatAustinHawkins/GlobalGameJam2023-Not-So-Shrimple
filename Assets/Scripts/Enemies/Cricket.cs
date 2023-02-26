using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cricket : MonoBehaviour
{
    public GameObject Player;

    public Animator CricketAnim;

    public float timer;

    public bool timerbegin;

    public GameObject CricketDeadGO;

    public Sprite CricketAttack;
    public Sprite CricketNormal;

    public SpriteRenderer spriteRenderer;

    public void Start()
    {
        CricketAnim = gameObject.GetComponent<Animator>();
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
            spriteRenderer.sprite = CricketNormal;
            CricketAnim.Play("CricketIdle");
            timerbegin = false;
            timer = 0f;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Player.GetComponent<PlayerMovement>().HealthDecrease();
        spriteRenderer.sprite = CricketAttack;
        timerbegin = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        CricketDeadGO.SetActive(true);
        gameObject.SetActive(false);
    }
}
