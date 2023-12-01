using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textUi : MonoBehaviour
{
    private List<int> listeCoin = new List<int> { 999, 5, 8, 6, 2 };
    public int nbTurn = 1;
    public TMP_Text coinText;
    public TMP_Text playerText;
    public TMP_Text turnText;

    private void Update()
    {
        coinText.text = "Thune : " + listeCoin[1];
        turnText.text = "Tour : " + nbTurn;
        playerText.text = "Joueur " ;
    }
}
