using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneOnButtonClick : MonoBehaviour
{

    [SerializeField] AudioManager audiomanager;

    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(LoadScene);
    }

    void LoadScene()
    {
        SceneManager.LoadScene(0);
    }
}
