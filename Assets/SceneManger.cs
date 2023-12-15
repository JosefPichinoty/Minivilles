using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManger : MonoBehaviour
{
    public GameObject startScene;
    public GameObject gameScene;

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LaunchGame()
    {
        startScene.SetActive(false);
        gameScene.SetActive(true);
    }
    

}
