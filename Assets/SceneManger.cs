using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManger : MonoBehaviour
{
    public string restartScene;
    public string menuScene;

    public void RestartScene()
    {
        Application.Quit();
    }

    public void MenuScene()
    {
        SceneManager.LoadScene(menuScene);
    }

}
