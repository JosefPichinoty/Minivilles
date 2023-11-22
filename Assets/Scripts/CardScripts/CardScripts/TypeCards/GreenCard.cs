using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCard : Card
{
    public GreenCard(string pName, int pValueM, int pValueD, int pSecondValue, bool pOnlyCard, typeCard pType) : base(pName, pValueM, pValueD, pSecondValue, pOnlyCard, pType)
    {
        valueDice = pValueD;
        secondValueDice = pSecondValue;
        valueMoney = pValueM;
        nameCard = pName;
        onlyCard = pOnlyCard;
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
            if (nameCard == "Boulangerie")
            {
                owner.money++;
            }
            if (nameCard == "Supérette")
            {
                owner.money += 3;
            }
        }
        else if (type == typeCard.factory)
        {
            if (nameCard == "Fromagerie")
            {
                foreach (Card card in owner.cardObtained)
                {
                    if (card.type == typeCard.animal)
                    {
                        owner.money += 3;
                    }
                }
            }
            if (nameCard == "Fabrique de meubles")
            {
                foreach (Card card in owner.cardObtained)
                {
                    if (card.type == typeCard.industry)
                    {
                        owner.money += 3;
                    }
                }
            }
        }
        else if (type == typeCard.fruits)
        {
            if (nameCard == "Marché de fruits et légumes")
            {
                foreach (Card card in owner.cardObtained)
                {
                    if (card.type == typeCard.wheat)
                    {
                        owner.money += 2;
                    }
                }
            }
        }
    }
}
