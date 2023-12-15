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
    
    public override void Effect(int nombre, ref bool didEffect)  //Cette fonction permet de lancer les effets des cartes si le joueur fait le bon lancé de dés.
    {
        if (type == typeCard.shop)
        {
            if ((nombre == 2 || nombre == 3 ) && data.nameCard == "Boulangerie")
            {
                owner.money++;
                didEffect = true;
                PlayerManager.GetInstance().NotifPanel.GetComponent<Notification>().moneyGained = 2;

                CommercialCenterEffect();
            }
            if ( nombre == 4 && data.nameCard == "Supérette")
            {
                owner.money += 3;
                PlayerManager.GetInstance().NotifPanel.GetComponent<Notification>().moneyGained = 3;

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
                        PlayerManager.GetInstance().NotifPanel.GetComponent<Notification>().moneyGained = 3;

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
                        PlayerManager.GetInstance().NotifPanel.GetComponent<Notification>().moneyGained = 1;

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
                        PlayerManager.GetInstance().NotifPanel.GetComponent<Notification>().moneyGained = 2;

                        owner.money += 2;
                    }
                }
            }
        }
        base.Effect(nombre, ref didEffect);
    }
    
}
