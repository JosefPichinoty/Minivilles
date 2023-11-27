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
    public List<Card> monumentList = new List<Card>();
    public List<Card> monumentAcquired = new List<Card>();

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

    public void ChangeTurn()
    {
        if (playerTurn == true)
        {
            GameManager.GetInstance().activePlayer = this;
        }
    }

    public void Turn()
    {

    }

    /*public void BuyCard()
    {
        //MARCHE PAS ENCORE
        if (GameManager.GetInstance().selectedCard.data.onlyCard != true && GameManager.GetInstance().selectedCard.data.numCard != 0)
        {
            if (GameManager.GetInstance().selectedCard.buyable == true)
            {
                GameManager.GetInstance().selectedCard.owner = this;
            }
        }
    }*/

    public void BuyMonument()
    {
        foreach (OrangeCard monument in monumentList)
        {
            if (monument.data.valueMoney <= money)
            {
                monument.buyable = true;
            }
        }

        foreach (OrangeCard monument in monumentList)
        {

        }
    }

    
}
