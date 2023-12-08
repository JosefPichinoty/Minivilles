using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Notification : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;
    public float fadeTime = 5;
    private Animator anim;

    [SerializeField]
    Sprite goodNotif;
    [SerializeField]
    Sprite badNotif;

    public int moneyGained;


    private UnityEngine.UI.Image panelNotif;

    static private Notification instance;

    static public Notification GetInstance()
    {
        if (instance == null) instance = new Notification();
        return instance;
    }

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        anim.enabled = false;
        text = this.GetComponent<TextMeshProUGUI>();
        panelNotif = this.GetComponent<UnityEngine.UI.Image>();
    }

    void Update()
    {

        /*
        if(fadeTime > 0)
        {
            alphaValue -= fadeAwayPerSecond * Time.deltaTime;
            text.color = new Color(text.color.r, text.color.g, text.color.b, alphaValue);
            panelNotif.color = new Color(panelNotif.color.r, panelNotif.color.g, panelNotif.color.b, alphaValue);
        }
        */
    }

    public void showMoneyNotif()
    {
        gameObject.SetActive(true);
        if(moneyGained == 1) {
            text.text = "Vous avez gagné " + moneyGained + " piece !";

        }
        else
        {
            text.text = "Vous avez gagné " + moneyGained + " pieces !";

        }
        Invoke("fadeOut", 3f);

    }

    public void showGoodNotif()
    {
        gameObject.GetComponent<UnityEngine.UI.Image>().sprite = goodNotif;

        gameObject.SetActive(true);

    }

    public void showBadNotif()
    {
        gameObject.GetComponent<UnityEngine.UI.Image>().sprite = badNotif;

        gameObject.SetActive(true);

    }


    public void changeText(string textShow)
    {
        text.text = textShow;
    }

    public void fadeOut()
    {
        anim.enabled = true;
        anim.Play("Notificacion");
        Invoke("disable", 2f);
    }

    public void disable()
    {
        gameObject.SetActive(false);
    }





}
