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
    private Animator anim;

    [SerializeField]
    Sprite goodNotif;
    [SerializeField]
    Sprite badNotif;

    public int moneyGained;

    [SerializeField]
    private UnityEngine.UI.Image img;

    private Color transp;
    private Color solid;

    static private Notification instance;

    static public Notification GetInstance()
    {
        if (instance == null) instance = new Notification();
        return instance;
    }

    private void Start()
    {
        if (instance != null)
        {
            Destroy(instance);
            return;
        }
        instance = this;

        solid = new Color(img.color.r, img.color.g, img.color.b, 255);
        transp = new Color(img.color.r, img.color.g, img.color.b, 0);
        img.color = new Color(img.color.r, img.color.g, img.color.b, 0);
        text.color = new Color(text.color.r, text.color.g, text.color.b, 0);
        anim = gameObject.GetComponent<Animator>();
        anim.enabled = false;
    }

    void Update()
    {
        if (anim != null && !anim.GetCurrentAnimatorStateInfo(0).IsName("Notificacion"))
        {
            // Desactivar el componente Animator
            anim.enabled = false;
            /*
            if(fadeTime > 0)
            {
                alphaValue -= fadeAwayPerSecond * Time.deltaTime;
                text.color = new Color(text.color.r, text.color.g, text.color.b, alphaValue);
                panelNotif.color = new Color(panelNotif.color.r, panelNotif.color.g, panelNotif.color.b, alphaValue);
            }
            */
        }
        else
        {
            anim.enabled = true;
        }
    }

    public void showMoneyNotif()
    {
        img.sprite = goodNotif;

        img.color = solid;
        text.color = solid;
        if(moneyGained == 1) {
            text.text = "Vous avez gagné " + moneyGained + " piece !";

        }
        else
        {
            text.text = "Vous avez gagné " + moneyGained + " pieces !";

        }
        Invoke("fadeOut", 2f);

    }

    public void showGoodNotif()
    {

        gameObject.SetActive(true);
        img.color = solid;
        text.color = solid;

        gameObject.GetComponent<UnityEngine.UI.Image>().sprite = goodNotif;

        Invoke("fadeOut", 2f);
    }

    public void showBadNotif()
    {
        gameObject.SetActive(true);
        img.color = solid;
        text.color = solid;

        
        gameObject.GetComponent<UnityEngine.UI.Image>().sprite = badNotif;

        Invoke("fadeOut", 2f);

    }

    public void disable()
    {
        gameObject.SetActive(false);
    }

    public void changeText(string textShow)
    {
        if(text == null)
        {
            Debug.Log("NULL");
        }
        text.text = textShow;
    }

    public void fadeOut()
    {
        anim.enabled = true;
        anim.Play("Notificacion");
    }

 






}
