using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PurpleCard : Card
{
    public PurpleCard(CardData pData, typeCard pType) : base(pData, pType)
    {
        data = pData;
        type = pType;
    }

    bool wantSwitchCard;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public override void Effect(int nombre, ref bool didEffect)
    {
        if (nombre == 6 && data.nameCard == "Stade")
        {
            int gainedMoney = 0;

            foreach (Player player in PlayerManager.GetInstance().playerList)
            {
                if (player != GameManager.GetInstance().activePlayer)
                {
                    gainedMoney += 2;
                    PlayerManager.GetInstance().NotifPanel.GetComponent<Notification>().moneyGained = 2;

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
        base.Effect(nombre, ref didEffect);
    }

    public void GetTarget()
    {
        //Quand on va cliquer sur le joueur a target, le joueur sera stocké dans une variable (pour l'effet de la chaine de télévision).
    }

    public void SwitchCards()
    {
        bool stopPlayerSearching = false;
        if (wantSwitchCard)
        {
            if (GameManager.GetInstance().firstSwitchCard != null && GameManager.GetInstance().secondSwitchCard != null)
            {
                foreach (Player player in PlayerManager.GetInstance().playerList)
                {
                    for (int i = 0; i < GameManager.GetInstance().activePlayer.cardObtained.Count; i++)
                    {
                        if (GameManager.GetInstance().activePlayer.cardObtained[i].data.nameCard == GameManager.GetInstance().firstSwitchCard.GetComponent<CardContainer>().cardData.nameCard && (player == GameManager.GetInstance().activePlayer))
                        {
                            GameManager.GetInstance().activePlayer.cardObtained.RemoveAt(i);
                            for (int j = 0; j < CardLibrary.GetInstance().brutCardContainer.Count; j++)
                            {
                                if (CardLibrary.GetInstance().brutCardContainer[j].data.nameCard == GameManager.GetInstance().firstSwitchCard.GetComponent<CardContainer>().cardData.nameCard)
                                {
                                    GameManager.GetInstance().activePlayer.cardObtained.Add(CardLibrary.GetInstance().brutCardContainer[j]);
                                    GameManager.GetInstance().activePlayer.cardObtained.Last().owner = GameManager.GetInstance().activePlayer;
                                    Debug.Log(GameManager.GetInstance().activePlayer.name + "obtained " + player.cardObtained.Last());
                                }
                            }
                        }
                    }
                    for (int k = 0; k < player.cardObtained.Count; k++)
                    {
                        if (player.cardObtained[k].data.nameCard == GameManager.GetInstance().secondSwitchCard.GetComponent<CardContainer>().cardData.nameCard && player != GameManager.GetInstance().activePlayer && !stopPlayerSearching)
                        {
                            player.cardObtained.RemoveAt(k);
                            for (int l = 0; l < CardLibrary.GetInstance().brutCardContainer.Count; l++)
                            {
                                if (CardLibrary.GetInstance().brutCardContainer[l].data.nameCard == GameManager.GetInstance().secondSwitchCard.GetComponent<CardContainer>().cardData.nameCard)
                                {
                                    player.cardObtained.Add(CardLibrary.GetInstance().brutCardContainer[l]);
                                    player.cardObtained.Last().owner = player;
                                    Debug.Log(player.name + "obtained " + player.cardObtained.Last());
                                    stopPlayerSearching = true;
                                }
                            }
                        }
                    }
                }
            }
            wantSwitchCard = false;
            GameManager.GetInstance().firstSwitchCard = null;
            GameManager.GetInstance().secondSwitchCard = null;
        }
    }
}
