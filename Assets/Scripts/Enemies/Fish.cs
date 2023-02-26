using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public GameObject Player;

    public Animator FishAnim;

    public float timer;

    public bool timerbegin;

    public GameObject FishDeadGO;

    public Sprite FishAttack;
    public Sprite FishNormal;

    public SpriteRenderer spriteRenderer;

    public void Start()
    {
        FishAnim = gameObject.GetComponent<Animator>();
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
            spriteRenderer.sprite = FishNormal;
            FishAnim.Play("FishIdle");
            timerbegin = false;
            timer = 0f;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Player.GetComponent<PlayerMovement>().HealthDecrease();
        spriteRenderer.sprite = FishAttack;
        timerbegin = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        FishDeadGO.SetActive(true);
        gameObject.SetActive(false);
    }
}
