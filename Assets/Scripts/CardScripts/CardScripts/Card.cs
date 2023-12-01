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
        ChangeStateCard();
    }

    public void ChangeStateCard()
    {
        Debug.Log("ça rentre");
        foreach (Player player in PlayerManager.GetInstance().playerList)
        {
            foreach (OrangeCard monument in player.monumentList)
            {
                if (monument.owner.money >= monument.data.valueMoney)
                {
                    monument.buyable = true;
                    GameManager.GetInstance().CheckMonuments();
                    Debug.Log("canBuy = " +  monument);
                }
                else
                {
                    monument.buyable = false;
                    Debug.Log("cantBuy = " + monument);
                }
            }

        }
    }
}