using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardContainer : MonoBehaviour
{
    public CardData cardData;
    public bool monumentOwned = false;

    public void BuyMonument()
    {
        if (GameManager.GetInstance().activePlayer.money >= cardData.valueMoney && monumentOwned == false)
        {
            GameManager.GetInstance().activePlayer.money -= cardData.valueMoney;
            monumentOwned = true;
        }
    }

}
