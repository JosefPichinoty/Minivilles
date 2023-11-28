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

    public override void Effect()
    {
        if (data.nameCard == "Caf�" && data.dice.diceThrow == 3)
        {
            GameManager.GetInstance().activePlayer.money--;
            owner.money++;
            if (owner.bonusMoney == true)
            {
                owner.money++;
            }
        }
        if (data.nameCard == "Restaurant" && (data.dice.diceThrow == 9 || data.dice.diceThrow == 10) )
        {
            GameManager.GetInstance().activePlayer.money -= 2;
            owner.money += 2;
            if (owner.bonusMoney == true)
            {
                owner.money++;
            }
        }
    }
}
