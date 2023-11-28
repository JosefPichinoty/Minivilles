using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonSFX : MonoBehaviour
{
    [SerializeField]
    private GameObject panel;

    [SerializeField]
    public Button yourButton;

    void Start()
    {
        yourButton = this.gameObject.GetComponent<Button>();
        if(this.gameObject.name != "PlayBtn")
        {
            panel = null;
        }
        yourButton.onClick.AddListener(TaskOnClick);

    }

    void TaskOnClick()
    {
        if (this.gameObject.name == "PlayBtn")
        {
            panel.SetActive(true);
        }
    }







}