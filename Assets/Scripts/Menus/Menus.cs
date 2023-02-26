using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{

    public void EasyMode()
    {
        SceneManager.LoadScene("EasyMode");
    }

    public void NormalMode()
    {
        SceneManager.LoadScene("NormalMode");
    }

    public void HardMode()
    {
        SceneManager.LoadScene("HardMode");
    }

    public void EndGame()
    {
        Application.Quit();
    }

    public void Options()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

    public void About()
    {
        SceneManager.LoadScene("AboutMenu");
    }

    public void Open1Tutorial()
    {
        SceneManager.LoadScene("TutorialEasyMode");
    }

    public void Open2Tutorial()
    {
        SceneManager.LoadScene("TutorialNormalMode");
    }

    public void Open3Tutorial()
    {
        SceneManager.LoadScene("TutorialHardMode");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
