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
    public List<GameObject> cardObtainedScrptable = new List<GameObject>();
    public List<OrangeCard> monumentList = new List<OrangeCard>();
    public List<GameObject> monumentAcquired = new List<GameObject>();

    public bool canThrow = false;
    public bool bothDice = false;
    public bool bonusMoney = false;
    public bool playerTurn = false;
    public bool rethrowDice = false;
    public bool doubleTurn = false;
    public string playerName;
    public int money = 3;

    public void Start()
    {
        foreach (OrangeCard card in monumentList)
        {
            Debug.Log(card);
        }
    }

    void Update()
    {

    }

    public void CheckCardEffect()
    {
        if (playerTurn)
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
        else if (!playerTurn)
        {
            foreach (RedCard redCard in cardObtained)
            {
                redCard.Effect();
            }
        }

        foreach (BlueCard blueCard in cardObtained)
        {
            blueCard.Effect();
        }
    }

    public void BecomeActivePlayer()
    {
        GameManager.GetInstance().activePlayer = this;
        foreach (OrangeCard monument in monumentList)
        {
            Debug.Log(monument.data.name);
        }
    }

    public void Turn()
    {
        
    }

    public void BuyMonument()
    {
        
    }

    public void DisplayTurnOptions()
    {

    }

    public void AddBoughtCardToList()
    {
        
    }
}
