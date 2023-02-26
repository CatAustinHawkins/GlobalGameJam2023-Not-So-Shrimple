using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButttonAnimation : MonoBehaviour
{

    public Animator Button1Anim;
    public Animator Button2Anim;
    public Animator Button3Anim;

    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;

    public Animator EasyModeAnim;
    public Animator NormalModeAnim;
    public Animator HardModeAnim;

    public GameObject EasyModeButton;
    public GameObject NormalModeButton;
    public GameObject HardModeButton;

    public bool timerbegin;
    public float timer;

    private void Start()
    {
        Button1Anim = Button1.GetComponent<Animator>();
        Button2Anim = Button2.GetComponent<Animator>();
        Button3Anim = Button3.GetComponent<Animator>();

        EasyModeAnim = EasyModeButton.GetComponent<Animator>();
        NormalModeAnim = NormalModeButton.GetComponent<Animator>();
        HardModeAnim = HardModeButton.GetComponent<Animator>();
    }

    private void Update()
    {
        if(timerbegin)
        {
            timer = timer + 1 * Time.deltaTime;
        }

        if(timer > 0.35f)
        {
            EasyModeAnim.Play("EasyModeMove");
            NormalModeAnim.Play("NormalModeMove");
            HardModeAnim.Play("HardModeMove");
        }
    }

    public void StartClicked()
    {
        Button1Anim.Play("ButtonsMove1");
        Button2Anim.Play("ButtonsMove2");
        Button3Anim.Play("ButtonMove3");
        timerbegin = true;
    }

}
