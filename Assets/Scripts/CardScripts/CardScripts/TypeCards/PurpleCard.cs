using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleCard : Card
{
    public PurpleCard(string pName, int pValueM, int pValueD, int pSecondValue, bool pOnlyCard, typeCard pType) : base(pName, pValueM, pValueD, pSecondValue, pOnlyCard, pType)
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
        if (nameCard == "Stade")
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
        if (nameCard == "Centre d'affaires")
        {

        }
        if (nameCard == "Chaîne de télévision")
        {

        }
    }
}
