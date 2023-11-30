using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCard : Card
{
    public BlueCard(CardData pData, typeCard pType, bool pBuyable) : base(pData, pType, pBuyable)
    {
        data = pData;
        type = pType;
        buyable = pBuyable;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Effect()
    {
        if (type == typeCard.wheat)
        {
            if (data.dice.diceThrow == 1 && data.nameCard == "Champs de bl�")
            {
                owner.money++;
            }
            if (data.dice.diceThrow == 10 && data.nameCard == "Verger")
            {
                owner.money += 3;
            }
        }
        else if (type == typeCard.animal)
        {
            if (data.dice.diceThrow == 2 && data.nameCard == "Ferme")
            {
                owner.money++;
            }
        }
        else if (type == typeCard.industry)
        {
            if (data.dice.diceThrow == 5 && data.nameCard == "For�t")
            {
                owner.money++;
            }
            if (data.dice.diceThrow == 9 && data.nameCard == "Mine")
            {
                owner.money += 5;
            }
        }
    }
}