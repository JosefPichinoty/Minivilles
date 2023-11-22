using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleCard : Card
{
    public PurpleCard(CardData pData, typeCard pType) : base(pData, pType)
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
        if (data.nameCard == "Stade")
        {
            int gainedMoney = 0;

            foreach (Player player in GameManager.GetInstance().playerList)
            {
                if (player != GameManager.GetInstance().activePlayer)
                {
                    gainedMoney += 2;
                    player.money -= 2;
                }
            }
            owner.money += gainedMoney;
        }
        if (data.nameCard == "Centre d'affaires")
        {

        }
        if (data.nameCard == "Chaine de télévision")
        {

        }
    }
}
