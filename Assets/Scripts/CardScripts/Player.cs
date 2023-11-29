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
    public List<GameObject> monumentList = new List<GameObject>();
    public List<GameObject> monumentAcquired = new List<GameObject>();

    public bool bothDice = false;
    public bool bonusMoney = false;
    public bool playerTurn = false;
    public bool rethrowDice = false;
    public bool doubleTurn = false;
    public string playerName;
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

    public void BecomeActivePlayer()
    {
        GameManager.GetInstance().activePlayer = this;
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
