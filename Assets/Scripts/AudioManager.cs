using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{


    static private AudioManager instance;

    static public AudioManager GetInstance()
    {
        if (instance == null)
        {
            instance = new AudioManager();
        }
        return instance;
    }

    private AudioManager() : base() { }

    public AudioClip btnHover;
    public AudioClip btnClick;
    public AudioClip diceThrow;

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

    public void playDice()
    {
        audioSource[0].PlayOneShot(diceThrow);
    }
}
