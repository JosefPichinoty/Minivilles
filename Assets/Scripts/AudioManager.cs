using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance;
    public AudioClip btnSound;

    private AudioSource audioSource;

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
        audioSource = GetComponent<AudioSource>();


    }

    public void playBtnSound()
    {
        audioSource.clip = btnSound;
        audioSource.PlayOneShot(btnSound);
    }

    public void PlayMusic()
    {
        audioSource.PlayOneShot(music);
    }
}
