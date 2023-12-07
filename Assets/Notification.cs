using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Notification : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;
    private int moneyGained;
    public float fadeTime = 5;
    private float fadeAwayPerSecond;
    private float alphaValue;


    private UnityEngine.UI.Image panelNotif;



    private void Start()
    {
        gameObject.SetActive(false);
        text = this.GetComponent<TextMeshProUGUI>();
        panelNotif = this.GetComponent<UnityEngine.UI.Image>();
        fadeAwayPerSecond = 1 / fadeTime;
        //alphaValue = text.color.a;
    }

    void Update()
    {
        if(fadeTime > 0)
        {
            alphaValue -= fadeAwayPerSecond * Time.deltaTime;
            text.color = new Color(text.color.r, text.color.g, text.color.b, alphaValue);
            panelNotif.color = new Color(panelNotif.color.r, panelNotif.color.g, panelNotif.color.b, alphaValue);
        }
    }

    private void showNotif()
    {
        gameObject.SetActive(true);
        text.text = "Vous avez gagné " + moneyGained + " pieces";
    }


}
