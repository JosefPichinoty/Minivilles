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

    /*
    public override void Effect()
    {
        if (type == typeCard.wheat)
        {
            if (DiceThrow.GetInstance().nombre == 1 && data.nameCard == "Champs de blé")
            {
                Debug.Log("NOOOOOOOOOOOOOOOOOOOOON");
                owner.money++;
            }
            if (DiceThrow.GetInstance().nombre == 10 && data.nameCard == "Verger")
            {
                owner.money += 3;
            }
        }
        else if (type == typeCard.animal)
        {
            if (DiceThrow.GetInstance().nombre == 2 && data.nameCard == "Ferme")
            {
                owner.money++;
            }
        }
        else if (type == typeCard.industry)
        {
            if (DiceThrow.GetInstance().nombre == 5 && data.nameCard == "Forêt")
            {
                owner.money++;
            }
            if (DiceThrow.GetInstance().nombre == 9 && data.nameCard == "Mine")
            {
                owner.money += 5;
            }
        }
        base.Effect();

    
    }
    */
}

    