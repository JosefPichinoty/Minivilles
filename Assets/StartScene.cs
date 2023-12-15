using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartScene : MonoBehaviour
{
    public GameObject game;
    public GameObject start;

    public void starGame()
    {
        game.SetActive(true);
        start.SetActive(false);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
