using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyText : MonoBehaviour
{
    static private MoneyText instance;

    static public MoneyText GetInstance()
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

    public void ChangeText()
    {
        textMoney.text = "Player Money: " + Convert.ToString(GameManager.GetInstance().activePlayer.money);
    }
}
