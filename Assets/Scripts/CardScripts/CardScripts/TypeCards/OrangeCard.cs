using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeCard : Card
{
    public OrangeCard(CardData pData, typeCard pType) : base(pData, pType)
    {
        data = pData;
        type = pType;
    }

    bool obtained;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Effect()
    {
        if (obtained)
        {
            if (data.nameCard == "Gare")
            {
                owner.bothDice = true;
            }
            if (data.nameCard == "Centre Commercial")
            {
                owner.bonusMoney = true;
            }
            if (data.nameCard == "Parc d'attractions")
            {
                /*if(diceResult1 == diceResult2)
                {
                    TurnPlayer()
                }*/
            }
            if (data.nameCard == "Tour radio")
            {
                owner.rethrowDice = true;
            }
        }
    }
}