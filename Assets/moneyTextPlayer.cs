using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class moneyTextPlayer : MonoBehaviour
{
    [SerializeField] private TMP_Text p1Money;
    [SerializeField] private TMP_Text p2Money;
    [SerializeField] private TMP_Text p3Money;
    [SerializeField] private TMP_Text p4Money;

    private void Update()
    {
        p1Money.text = PlayerManager.GetInstance().player1.money.ToString();
        p2Money.text = PlayerManager.GetInstance().player2.money.ToString();
        p3Money.text = PlayerManager.GetInstance().player3.money.ToString();
        p4Money.text = PlayerManager.GetInstance().player4.money.ToString();
    }
}
    