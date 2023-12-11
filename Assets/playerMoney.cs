using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.PlayerLoop;

public class playerMoney : MonoBehaviour
{
    [SerializeField] private TMP_Text p1money;
    [SerializeField] private TMP_Text p2money;
    [SerializeField] private TMP_Text p3money;
    [SerializeField] private TMP_Text p4money;

    private void Update()
    {
        p1money.text = PlayerManager.GetInstance().player1.money.ToString();
        p2money.text = PlayerManager.GetInstance().player2.money.ToString();
        p3money.text = PlayerManager.GetInstance().player3.money.ToString();
        p4money.text = PlayerManager.GetInstance().player4.money.ToString();
    }
}
