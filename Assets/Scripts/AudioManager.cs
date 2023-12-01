using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance;
    
    public AudioClip btnHover;
    public AudioClip btnClick;


    public AudioSource[] audioSource;

    [SerializeField]
    private AudioClip music;


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {


    }

    public void playHover()
    {
        audioSource[0].PlayOneShot(btnHover);
    }

    public void playClick()
    {
        audioSource[0].PlayOneShot(btnClick);
    }

    public void PlayMusic()
    {
        audioSource[1].PlayOneShot(music);
    }
}
