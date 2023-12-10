using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UIElements;

public class Card
    {
    public Card(CardData pData, typeCard pType)
    {
        data = pData;
        type = pType;
    }

    public bool buyable;
    public CardData data;
    public Player owner;
    public DiceThrow dice;
    public GameManager _gm;

    public typeCard type;

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

    public virtual void Effect(int nombre, ref bool didEffect)
    {
        ChangeStateCard();
    }

    public virtual void CommercialCenterEffect()
    {
        if (owner.bonusMoney == true)
        {
            owner.money++;
        }
    }

    public void ChangeStateCard()
    {
        foreach (Player player in PlayerManager.GetInstance().playerList)
        {
            foreach (OrangeCard monument in player.monumentList)
            {
                if (monument.owner.money >= monument.data.valueMoney)
                {
                    monument.buyable = true;
                    GameManager.GetInstance().CheckMonuments();
                }
                else
                {
                    monument.buyable = false;
                }
            }

        }
    }
}