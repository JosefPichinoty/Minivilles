using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Card
    {
    public Card(CardData pData, typeCard pType)
    {
        data = pData;
        type = pType;
    }

    public CardData data;
    public Player owner;

    public bool buyable = false;

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

    public virtual void Effect()
    {

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
                }
            }
            foreach (Card card in player.cardObtained)
            {
                if (card.owner.money >= card.data.valueMoney)
                {
                    card.buyable = true;
                }
            }
        }
    }
}