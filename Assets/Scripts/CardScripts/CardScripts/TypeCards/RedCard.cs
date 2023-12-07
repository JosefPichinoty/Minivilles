using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCard : Card
{
    public RedCard(CardData pData, typeCard pType) : base(pData, pType)
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

    /*
    public override void Effect()
    {
        if (DiceThrow.GetInstance().nombre == 3 && data.nameCard == "Café")
        {
            GameManager.GetInstance().activePlayer.money--;
            owner.money++;
            CommercialCenterEffect();
        }
        if ((DiceThrow.GetInstance().nombre == 9 || DiceThrow.GetInstance().nombre == 10) && data.nameCard == "Restaurant")
        {
            GameManager.GetInstance().activePlayer.money -= 2;
            owner.money += 2;
            CommercialCenterEffect();
        }
        base.Effect();

    }
    */
}
