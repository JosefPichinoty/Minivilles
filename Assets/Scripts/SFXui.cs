using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class SFXui : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField]
    private GameObject audioManager;
    private AudioSource audio;
    private Button thisBtn;
    [SerializeField]
    private AudioClip hoverSFX;
    [SerializeField]
    private AudioClip clickSFX;

    void Start()
    {
        audio = audioManager.GetComponent<AudioSource>();
        thisBtn = this.gameObject.GetComponent<Button>();
        thisBtn.onClick.AddListener(playClickSFX);
    }

    public void OnPointerEnter(PointerEventData ped)
    {
        audio.clip = hoverSFX;
        audio.Play();
    }

    public void playClickSFX()
    {
        audio.clip = clickSFX;
        audio.Play();
    }

}
