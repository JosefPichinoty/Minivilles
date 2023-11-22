using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCard : Card
{
    public RedCard(string pName, int pValueM, int pValueD, int pSecondValue, bool pOnlyCard, typeCard pType) : base(pName, pValueM, pValueD, pSecondValue, pOnlyCard, pType)
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
        if (nameCard == "Café")
        {

        }
        if (nameCard == "Restaurant")
        {

        }
    }
}
