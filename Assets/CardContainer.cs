using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CardContainer : MonoBehaviour
{
    public CardData cardData;
    public bool monumentOwned = false;
    private int trash = 0;

    public void BuyMonument()
    {
        if (GameManager.GetInstance().activePlayer.money >= cardData.valueMoney && monumentOwned == false)
        {
            GameManager.GetInstance().activePlayer.money -= cardData.valueMoney;
            monumentOwned = true;
            GameManager.GetInstance().activePlayer.monumentAcquired.Add(cardData);
            for (int i = 0; i < CardLibrary.GetInstance().brutMonumentContainer.Count; i++)
            {
                if (CardLibrary.GetInstance().brutMonumentContainer[i].data.name == cardData.name)
                {
                    GameManager.GetInstance().activePlayer.monumentObtained.Add((OrangeCard)CardLibrary.GetInstance().brutMonumentContainer[i]);
                    GameManager.GetInstance().activePlayer.monumentObtained.Last().Effect(trash);
                }
            }
        }
    }
}
