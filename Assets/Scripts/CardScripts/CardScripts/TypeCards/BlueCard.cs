using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCard : Card
{
    public BlueCard(CardData pData, typeCard pType) : base(pData, pType)
    {
        data = pData;
        type = pType;
    }

    // Update is called once per frame
    void Update()
    {

    }

    
    public override void Effect(int nombre, bool didEffect)
    {
        if (type == typeCard.wheat)
        {
            if (dice.nombre1 == 1 && data.nameCard == "Champs de blé")
            {
                Debug.Log("NOOOOOOOOOOOOOOOOOOOOON");
                owner.money++;
                didEffect = true;
            }
            if (nombre == 10 && data.nameCard == "Verger")
            {
                didEffect = true;
                owner.money += 3;
            }
        }
        else if (type == typeCard.animal)
        {
            if ( (dice.total == 2) && data.nameCard == "Ferme")
            {
                didEffect = true;

                owner.money++;
            }
        }
        else if (type == typeCard.industry)
        {
            if (nombre == 5 && data.nameCard == "Forêt")
            {
                didEffect = true;

                owner.money++;
            }
            if (nombre == 9 && data.nameCard == "Mine")
            {
                didEffect = true;

                owner.money += 5;
            }
        }
        base.Effect(nombre, didEffect);

    
    }
    
}

    