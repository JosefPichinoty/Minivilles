using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(fileName = "newPlayer", menuName = "playerContainer/player")]
public class Player : ScriptableObject
{
    public Color color;

    public List<Card> cardObtained = new List<Card>();
    public List<Card> monumentObtained = new List<Card>();

    public bool bothDice = false;
    public bool bonusMoney = false;
    public bool playerTurn = false;
    public bool rethrowDice = false;
    public int money = 3;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void CheckCardEffect()
    {
        if (playerTurn == true)
        {
            foreach (GreenCard greenCard in cardObtained)
            {
                greenCard.Effect();
            }

            foreach (PurpleCard purpleCard in cardObtained)
            {
                purpleCard.Effect();
            }
        }

        foreach (BlueCard blueCard in cardObtained)
        {
            blueCard.Effect();
        }
    }

    void BuyCard()
    {
        if (/*selectedCard.onlyCard == true && numCardObtained = 1*/ 1 == 1)
        {
            //On peut pas acheter
        }
    }

    public void ChangeTurn()
    {
        if (playerTurn == true)
        {
            GameManager.GetInstance().activePlayer = this;
        }
    }
}
