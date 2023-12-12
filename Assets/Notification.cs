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

        img.color = new Color(img.color.r, img.color.g, img.color.b, 0);
        text.color = new Color(text.color.r, text.color.g, text.color.b, 0);
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
    }

    public void showMoneyNotif()
    {
        img.sprite = goodNotif;

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
        anim.SetTrigger("goodTrigger");
        //gameObject.SetActive(true);

        gameObject.GetComponent<UnityEngine.UI.Image>().sprite = goodNotif;

    }

    public void showBadNotif()
    {

        //gameObject.SetActive(true);
        anim.SetTrigger("badTrigger");

        
        gameObject.GetComponent<UnityEngine.UI.Image>().sprite = badNotif;


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
