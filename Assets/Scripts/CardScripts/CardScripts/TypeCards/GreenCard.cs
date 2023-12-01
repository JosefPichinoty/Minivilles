using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCard : Card
{
    public GreenCard(CardData pData, typeCard pType) : base(pData, pType)
    {
        data = pData;
        type = pType;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Effect()
    {
        if (type == typeCard.shop)
        {
            if ( (data.dice.diceThrow == 2 || data.dice.diceThrow == 3) && data.nameCard == "Boulangerie")
            {
                owner.money++;
            }
            if (data.nameCard == "Supérette")
            {
                owner.money += 3;
            }
        }
        else if (type == typeCard.factory)
        {
            if (data.dice.diceThrow == 7 && data.nameCard == "Fromagerie")
            {
                foreach (Card card in owner.cardObtained)
                {
                    if (type == typeCard.animal)
                    {
                        owner.money += 3;
                    }
                }
            }
            if (data.dice.diceThrow == 8 && data.nameCard == "Fabrique de meubles")
            {
                foreach (Card card in owner.cardObtained)
                {
                    if (type == typeCard.industry)
                    {
                        owner.money += 3;
                    }
                }
            }
        }
        else if (type == typeCard.fruits)
        {
            if ( (data.dice.diceThrow == 11 || data.dice.diceThrow == 12) && data.nameCard == "Marché de fruits et légumes")
            {
                foreach (Card card in owner.cardObtained)
                {
                    if (type == typeCard.wheat)
                    {
                        owner.money += 2;
                    }
                }
            }
        }
    }
}
