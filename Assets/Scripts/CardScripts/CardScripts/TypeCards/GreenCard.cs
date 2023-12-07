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
    
    public override void Effect(int nombre, bool didEffect)
    {
        if (type == typeCard.shop)
        {
            if ((nombre == 2 || nombre == 3 ) && data.nameCard == "Boulangerie")
            {
                owner.money++;
                didEffect = true;
                CommercialCenterEffect();
            }
            if (data.nameCard == "Supérette")
            {
                owner.money += 3;
                didEffect = true;

                CommercialCenterEffect();
            }
        }
        else if (type == typeCard.factory)
        {
            if (nombre == 7 && data.nameCard == "Fromagerie")
            {
                foreach (Card card in owner.cardObtained)
                {
                    if (type == typeCard.animal)
                    {
                        didEffect = true;

                        owner.money += 3;
                    }
                }
            }
            if (nombre == 8 && data.nameCard == "Fabrique de meubles")
            {
                foreach (Card card in owner.cardObtained)
                {
                    if (type == typeCard.industry)
                    {
                        didEffect = true;

                        owner.money += 3;
                    }
                }
            }
        }
        else if (type == typeCard.fruits)
        {
            if ( (nombre == 11 || nombre == 12) && data.nameCard == "Marché de fruits et légumes")
            {
                foreach (Card card in owner.cardObtained)
                {
                    if (type == typeCard.wheat)
                    {
                        didEffect = true;

                        owner.money += 2;
                    }
                }
            }
        }
        base.Effect(nombre, didEffect);
    }
    
}
