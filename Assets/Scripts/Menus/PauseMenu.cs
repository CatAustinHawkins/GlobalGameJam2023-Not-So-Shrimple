using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public GameObject PauseMenuGO;

    public void Pause()
    {
        PauseMenuGO.SetActive(true);
    }

    public void Play()
    {
        PauseMenuGO.SetActive(false);
    }

}
