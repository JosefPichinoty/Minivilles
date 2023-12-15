using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartScene : MonoBehaviour
{
    public string launchScene;


    public void LaunchScene()
    {
        SceneManager.LoadScene("LisandroGameScene");
    }
}
