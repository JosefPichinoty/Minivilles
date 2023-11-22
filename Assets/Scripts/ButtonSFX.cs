using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonSFX : MonoBehaviour
{

    private AudioSource audio;
    [SerializeField]
    private GameObject panel;

    [SerializeField]
    public Button yourButton;

    void Start()
    {
        audio = GetComponent<AudioSource>();

        yourButton.onClick.AddListener(TaskOnClick);

    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        panel.SetActive(true);
    }

    public void playSFX()
    {
        audio.Play();
    }

    public void modalPlayers()
    {
        panel.SetActive(true);
    }






}