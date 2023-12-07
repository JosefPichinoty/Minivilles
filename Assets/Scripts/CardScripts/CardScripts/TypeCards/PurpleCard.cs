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

    Player playerTarget;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public override void Effect(int nombre, bool didEffect)
    {
        if (nombre == 6 && data.nameCard == "Stade")
        {
            int gainedMoney = 0;

            foreach (Player player in PlayerManager.GetInstance().playerList)
            {
                if (player != GameManager.GetInstance().activePlayer)
                {
                    gainedMoney += 2;
                    player.money -= 2;
                    didEffect = true;

                }
            }
            owner.money += gainedMoney;
        }
        if (nombre == 6 && data.nameCard == "Centre d'affaires")
        {
            //owner.TradeCard();

        }
        if (nombre == 6 && data.nameCard == "Chaine de télévision")
        {
            //owner.GetMoney();
        }
        base.Effect(nombre, didEffect);
    }
    


    public void GetTarget()
    {
        //Quand on va cliquer sur le joueur a target, le joueur sera stocké dans une variable (pour l'effet de la chaine de télévision).
    }
}
