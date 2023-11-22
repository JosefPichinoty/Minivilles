using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCard : Card
{
    public BlueCard(string pName, int pValueM, int pValueD, int pSecondValue, bool pOnlyCard, typeCard pType) : base(pName, pValueM, pValueD, pSecondValue, pOnlyCard, pType)
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
        if (type == typeCard.wheat)
        {
            if (nameCard == "Champs de blé")
            {
                owner.money++;
            }
            if (nameCard == "Verger")
            {
                owner.money += 3;
            }
        }
        else if (type == typeCard.animal)
        {
            if (nameCard == "Ferme")
            {
                owner.money++;
            }
        }
        else if (type == typeCard.industry)
        {
            if (nameCard == "Forêt")
            {
                owner.money++;
            }
            if (nameCard == "Mine")
            {
                owner.money += 5;
            }
        }
    }
}