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
            if ( (DiceThrow.GetInstance().nombre == 2 || DiceThrow.GetInstance().nombre == 3) && data.nameCard == "Boulangerie")
            {
                owner.money++;
                Debug.Log("OUIIIIIIIIIIIIIIIIIIIIIIIIIII");
            }
            if (data.nameCard == "Supérette")
            {
                owner.money += 3;
            }
        }
        else if (type == typeCard.factory)
        {
            if (DiceThrow.GetInstance().nombre == 7 && data.nameCard == "Fromagerie")
            {
                foreach (Card card in owner.cardObtained)
                {
                    if (type == typeCard.animal)
                    {
                        owner.money += 3;
                    }
                }
            }
            if (DiceThrow.GetInstance().nombre == 8 && data.nameCard == "Fabrique de meubles")
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
            if ( (DiceThrow.GetInstance().nombre == 11 || DiceThrow.GetInstance().nombre == 12) && data.nameCard == "Marché de fruits et légumes")
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
        base.Effect();
    }
}
