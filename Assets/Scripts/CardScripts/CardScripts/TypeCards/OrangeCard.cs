using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeCard : Card
{
    public OrangeCard(string pName, int pValueM, int pValueD, int pSecondValue, bool pOnlyCard, typeCard pType) : base(pName, pValueM, pValueD, pSecondValue, pOnlyCard, pType)
    {
        valueDice = pValueD;
        secondValueDice = pSecondValue;
        valueMoney = pValueM;
        nameCard = pName;
        onlyCard = pOnlyCard;
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
            if (nameCard == "Gare")
            {

            }
            if (nameCard == "Centre Commercial")
            {

            }
            if (nameCard == "Parc d'attractions")
            {

            }
            if (nameCard == "Tour radio")
            {

            }
        }
    }
}