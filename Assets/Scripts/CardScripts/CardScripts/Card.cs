using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class Card : ScriptableObject
{
    public Card(string pName, int pValueM, int pValueD, int pSecondValue, bool pOnlyCard, typeCard pType)
    {
        valueDice = pValueD;
        secondValueDice = pSecondValue;
        valueMoney = pValueM;
        nameCard = pName;
        onlyCard = pOnlyCard;
        type = pType;
    }
    public enum typeCard
    {
        wheat,
        animal,
        shop,
        coffee,
        industry,
        business,
        factory,
        fruits
    }

    public string nameCard;
    protected Player owner;
    public int valueMoney;
    public int valueDice;
    public int secondValueDice;
    //public int numCard;
    public int maxNumCard;
    public bool onlyCard;

    public typeCard type;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void CardBought(Player player)
    {
        owner = player;
    }

    public virtual void Effect()
    {

    }
}