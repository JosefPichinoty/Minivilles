using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerHand : MonoBehaviour
{
    private Transform handParent;
    [SerializeField] private List<CardStocker> cartes = new List<CardStocker>();
    [SerializeField] GameObject[] monuments;


    // Start is called before the first frame update
    void Start()
    {
        handParent = gameObject.GetComponent<Transform>().GetChild(0).GetChild(0).GetComponent<Transform>();
        for (int i = 0; i < 15; i++)
        {
            cartes.Add(new CardStocker(i));
        }
    }
    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.K))
        {
            GameManager.GetInstance().activePlayer.money += 2;
            print(GameManager.GetInstance().activePlayer.money);
        }
    }

    public void Buy()
    {
        for (int i = 0; i < 15; i++)
        {
            if (cartes[i].currentAmount == 0 && cartes[i].cardIndex == GameManager.GetInstance().selectedCard.GetComponent<CardContainer>().cardData.cardIndex)
            {
                print("avant = " + GameManager.GetInstance().activePlayer.money);
                if (GameManager.GetInstance().activePlayer.money >= GameManager.GetInstance().selectedCard.GetComponent<CardContainer>().cardData.valueMoney)
                {
                    AddCardBasic(cartes[i], GameManager.GetInstance().selectedCard);
                    GameManager.GetInstance().activePlayer.money -= GameManager.GetInstance().selectedCard.GetComponent<CardContainer>().cardData.valueMoney;
                    print("après = " + GameManager.GetInstance().activePlayer.money);
                }
            }
            else if(cartes[i].currentAmount > 0 && cartes[i].cardIndex == GameManager.GetInstance().selectedCard.GetComponent<CardContainer>().cardData.cardIndex)
            {
                if (cartes[i].currentAmount < GameManager.GetInstance().selectedCard.GetComponent<CardContainer>().cardData.maxNumCard)
                {
                    print("avant = " + GameManager.GetInstance().activePlayer.money);
                    if (GameManager.GetInstance().activePlayer.money >= GameManager.GetInstance().selectedCard.GetComponent<CardContainer>().cardData.valueMoney)
                    {
                        AddCardUpper(cartes[i], GameManager.GetInstance().selectedCard);
                        GameManager.GetInstance().activePlayer.money -= GameManager.GetInstance().selectedCard.GetComponent<CardContainer>().cardData.valueMoney;
                        print("après = " + GameManager.GetInstance().activePlayer.money);
                    }
                }
            }
        }
    }

    private void AddCardUpper(CardStocker cardStocker, GameObject prefab)
    {
        GameObject obj = Instantiate(prefab, cardStocker.carteStock[cardStocker.currentAmount - 1].transform);
        cardStocker.carteStock.Add(obj.gameObject);
        cartes[cardStocker.cardIndex].currentAmount++;
        GameManager.GetInstance().BuyUI.SetActive(false);
        obj.gameObject.GetComponent<Dissolve>().canDissolve = true;
    }
    private void AddCardBasic(CardStocker cardStocker, GameObject prefab)
    {
        GameObject obj = Instantiate(prefab, handParent.transform);
        cardStocker.carteStock.Add(obj.gameObject);
        cartes[cardStocker.cardIndex].currentAmount++;
        GameManager.GetInstance().BuyUI.SetActive(false);
        obj.gameObject.GetComponent<Dissolve>().canDissolve = true;
    }

    public void OpenBuyUI(GameObject prefab)
    {
        GameManager.GetInstance().BuyUI.SetActive(true);

        GameManager.GetInstance().selectedCard = prefab;
    }
}

[System.Serializable]
public class CardStocker
{ 
    public List<GameObject> carteStock = new List<GameObject>() { };
    public int maxAmount = 3;
    public int currentAmount = 0;
    public int cardIndex { get; set; }
    public CardStocker(int idCard) {
        cardIndex = idCard;
    }
}
