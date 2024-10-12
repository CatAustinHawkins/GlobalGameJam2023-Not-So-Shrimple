using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public int Health = 3;

    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;

    public GameObject Heart1Gone;
    public GameObject Heart2Gone;
    public GameObject Heart3Gone;

    public Animator PlayerAnim;

    public bool InMovement;

    public float timer;

    public float speed;
    public float jump;
    float moveVelocity;
    public Rigidbody rb;
    public bool isGrounded = true;

    public TextMeshProUGUI TerryCountText;
    public int TerryCount;
   
    void Start()
    {
        PlayerAnim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        //Grounded?
        if (isGrounded == true)
        {
            //jumping
            if (Input.GetKeyDown(KeyCode.W))
            {

                GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, jump);
                InMovement = true;
                PlayerAnim.Play("ShrimpJump");
            }

        }

        moveVelocity = 0;

        //Left Right Movement
        if (Input.GetKey(KeyCode.A))
        {
            moveVelocity = speed;
            gameObject.transform.localScale = new Vector3(-0.4f, 0.4f, 1f);
            InMovement = true;
            PlayerAnim.Play("ShrimpWalk");
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveVelocity = -speed;
            gameObject.transform.localScale = new Vector3(0.4f, 0.4f, 1f);
            InMovement = true;
            PlayerAnim.Play("ShrimpWalk");
        }

        InMovement = false;

        if (InMovement == false)
        {
            PlayerAnim.Play("ShrimpIdle");
        }

        GetComponent<Rigidbody>().velocity = new Vector3(moveVelocity, GetComponent<Rigidbody>().velocity.y);

    }
    void OnCollisionEnter()
    {
        isGrounded = true;
    }
    void OnCollisionExit()
    {
        isGrounded = false;
    }

    public void HealthDecrease()
    {
        PlayerAnim.Play("ShrimpHurt");

        if (Health == 1)
        {
            Heart1.SetActive(false);
            Health--;
            SceneManager.LoadScene("LoseScreen");
        }
        if (Health == 2)
        {
            Heart2.SetActive(false);
            Heart2Gone.SetActive(true);
            Health--;
        }
        if (Health == 3)
        {
            Heart3.SetActive(false);
            Heart3Gone.SetActive(true);
            Health--;
        }
    }

    public void TerryCollect()
    {
        TerryCount++;
        TerryCountText.text = TerryCount.ToString();
    }
}
