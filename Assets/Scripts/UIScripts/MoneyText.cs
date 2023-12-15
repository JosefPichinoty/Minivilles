using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MoneyText : MonoBehaviour
{
    static private MoneyText instance;

    static public MoneyText GetInstance() //On fait un singleton de MonetText
    {
        if (instance == null) instance = new MoneyText();
        return instance;
    }

    public TMP_Text textMoney;
    void Start()
    {

        if (instance != null)
        {
            Destroy(instance);
            return;
        }

        instance = this;

        textMoney = GetComponent<TMP_Text>();

        ChangeText();
    }

    public void ChangeText() //On actualise l'argent du joueur et on l'affiche
    {
        
        textMoney.text = Convert.ToString(GameManager.GetInstance().activePlayer.money);

    }
}
