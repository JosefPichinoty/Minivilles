using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyText : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text textMoney;
    void Start()
    {
        textMoney = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textMoney.text = "Player Money :" + Convert.ToString(GameManager.GetInstance().activePlayer.money);
    }
}
