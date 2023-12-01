using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class SFXui : MonoBehaviour, IPointerEnterHandler
{
    private AudioManager audioManager;
    private GameObject _audio;
    private Button thisBtn;


    void Start()
    {
        _audio = GameObject.Find("AudioManager");
        audioManager = _audio.GetComponent<AudioManager>();
        thisBtn = this.gameObject.GetComponent<Button>();
        thisBtn.onClick.AddListener(playClickSFX);
    }

    public void OnPointerEnter(PointerEventData ped)
    {
        _audio.GetComponent<AudioManager>().playHover();
    }

    public void playClickSFX()
    {
        _audio.GetComponent<AudioManager>().playClick();
    }

}
