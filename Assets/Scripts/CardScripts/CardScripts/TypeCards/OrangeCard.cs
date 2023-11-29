using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

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
        Effect();
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
                    owner.doubleTurn = true
                }*/
            }
            if (data.nameCard == "Tour radio")
            {
                owner.rethrowDice = true;
            }
        }
    }
}