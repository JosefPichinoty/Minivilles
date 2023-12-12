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
    int trash = 0;
    bool trash2;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Effect(trash, ref trash2);
    }

    public override void Effect(int nombre, ref bool didEffect)
    {
        if (data.nameCard == "Gare")
        {
            GameManager.GetInstance().activePlayer.bothDice = true;
            Debug.Log("Gare HAAA");
        }
        if (data.nameCard == "Centre Commercial")
        {
            GameManager.GetInstance().activePlayer.bonusMoney = true;
            //owner.bonusMoney = true;
            Debug.Log("Centre Commercial HAAA");
        }
        if (data.nameCard == "Parc d'attractions")
        {
            GameManager.GetInstance().activePlayer.playAgainAbility = true;
            //owner.playAgainAbility = true;
            Debug.Log("Parc HAAA");
            /*if(diceResult1 == diceResult2)
            {
                owner.doubleTurn = true
            }*/
        }
        if (data.nameCard == "Tour radio")
        {
            GameManager.GetInstance().activePlayer.rethrowDice = true;
            //owner.rethrowDice = true;
            Debug.Log("Tour radio HAAA");
        }
        base.Effect(nombre, ref didEffect);
    }
}