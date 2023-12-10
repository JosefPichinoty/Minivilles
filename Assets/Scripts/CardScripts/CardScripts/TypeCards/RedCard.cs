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

    
    public override void Effect(int nombre, ref bool didEffect)
    {
        if (nombre == 3  && data.nameCard == "Café")
        {
            GameManager.GetInstance().activePlayer.money--;
            owner.money++;
            PlayerManager.GetInstance().NotifPanel.GetComponent<Notification>().moneyGained = 1;

            didEffect = true;
            CommercialCenterEffect();
        }
        if ((nombre == 9 || nombre == 10) && data.nameCard == "Restaurant")
        {
            GameManager.GetInstance().activePlayer.money -= 2;
            owner.money += 2;
            PlayerManager.GetInstance().NotifPanel.GetComponent<Notification>().moneyGained = 2;

            didEffect = true;

            CommercialCenterEffect();
        }
        base.Effect(nombre, ref didEffect);

    }
    
}
