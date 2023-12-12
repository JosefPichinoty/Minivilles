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

    public String cardOwner;

    [SerializeField]
    Sprite goodNotif;
    [SerializeField]
    Sprite badNotif;

    public int moneyGained;

    [SerializeField]
    private Sprite[] imgs;

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

        img.color = new Color(img.color.r, img.color.g, img.color.b, 0);
        text.color = new Color(text.color.r, text.color.g, text.color.b, 0);
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
    }

    void changeColor()
    {
        if(cardOwner == "Player1")
        {
            img.sprite = imgs[0];

        }
        else
        {
            if(cardOwner == "Player2")
            {
                img.sprite = imgs[1];
            }
            else
            {
                if(cardOwner == "Player3")
                {
                    img.sprite = imgs[2];
                }
                else
                {
                    if(cardOwner == "Player4")
                    {
                        img.sprite = imgs[3];
                    }
                }
            }
        }
    }

    public void showMoneyNotif()
    {
        gameObject.SetActive(true);
        Debug.Log(cardOwner);
        changeColor();
        anim.SetTrigger("badTrigger");
        if (moneyGained == 1) {
            text.text = "Vous avez gagné " + moneyGained + " piece !";

        }
        else
        {
            text.text = "Vous avez gagné " + moneyGained + " pieces !";

        }

    }

    public void showGoodNotif()
    {
        gameObject.SetActive(true);
        changeColor();
        anim.SetTrigger("badTrigger");
        //gameObject.SetActive(true);


    }

    public void showBadNotif()
    {
        gameObject.SetActive(true);
        img.sprite = badNotif;
        //gameObject.SetActive(true);
        anim.SetTrigger("badTrigger");

        


    }

    public void disable()
    {
        anim.SetTrigger("exitTrigger");

    }

    public void changeText(string textShow)
    {
        if(text == null)
        {
            Debug.Log("NULL");
        }
        text.text = textShow;
    }


 






}
