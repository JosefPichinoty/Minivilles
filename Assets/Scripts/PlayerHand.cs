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

    [SerializeField] GameObject baseHand;


    void Start()
    {
        //On récupère l'endroit ou instancier les cartes et on initialise la main du joueur
        handParent = gameObject.GetComponent<Transform>().GetChild(0).GetChild(0).GetComponent<Transform>();
        for (int i = 0; i < 15; i++)
        {
            cartes.Add(new CardStocker(i));
        }
    }
    private void Update()
    {
        //Argent pour débug plus facilement
        if(Input.GetKeyDown(KeyCode.K))
        {
            GameManager.GetInstance().activePlayer.money += 2;
        }
    }

    //Fonction d'achats
    public void Buy()
    {
        for (int i = 0; i < 15; i++)
        {
            if (cartes[i].currentAmount == 0 && cartes[i].cardIndex == GameManager.GetInstance().selectedCard.GetComponent<CardContainer>().cardData.cardIndex && GameManager.GetInstance().activePlayer.canBuy)
            {
                if (GameManager.GetInstance().activePlayer.money >= GameManager.GetInstance().selectedCard.GetComponent<CardContainer>().cardData.valueMoney)
                {
                    AddCardBasic(cartes[i], GameManager.GetInstance().selectedCard, GameManager.GetInstance().activePlayer);
                    GameManager.GetInstance().activePlayer.money -= GameManager.GetInstance().selectedCard.GetComponent<CardContainer>().cardData.valueMoney;
                    GameManager.GetInstance().activePlayer.canBuy = false;
                }
                else
                {
                    if(GameManager.GetInstance().activePlayer.money < GameManager.GetInstance().selectedCard.GetComponent<CardContainer>().cardData.valueMoney)
                    {

                        PlayerManager.GetInstance().notif.changeText("Vous n'avez pas assez d'argent !");

                        PlayerManager.GetInstance().notif.showBadNotif();
                    }
                }
            }
            else if(cartes[i].currentAmount > 0 && cartes[i].cardIndex == GameManager.GetInstance().selectedCard.GetComponent<CardContainer>().cardData.cardIndex && GameManager.GetInstance().activePlayer.canBuy)
            {
                if (cartes[i].currentAmount < GameManager.GetInstance().selectedCard.GetComponent<CardContainer>().cardData.maxNumCard)
                {
                    print("avant = " + GameManager.GetInstance().activePlayer.money);
                    if (GameManager.GetInstance().activePlayer.money >= GameManager.GetInstance().selectedCard.GetComponent<CardContainer>().cardData.valueMoney)
                    {
                        AddCardUpper(cartes[i], GameManager.GetInstance().selectedCard, GameManager.GetInstance().activePlayer);
                        GameManager.GetInstance().activePlayer.canBuy = false;
                        GameManager.GetInstance().activePlayer.money -= GameManager.GetInstance().selectedCard.GetComponent<CardContainer>().cardData.valueMoney;
                        print("apr�s = " + GameManager.GetInstance().activePlayer.money);

                    }
                }
                else
                {
                    if (GameManager.GetInstance().activePlayer.money < GameManager.GetInstance().selectedCard.GetComponent<CardContainer>().cardData.valueMoney)
                    {
                        PlayerManager.GetInstance().notif.changeText("Vous n'avez pas assez d'argent !");
                        PlayerManager.GetInstance().notif.showBadNotif();
                    }
                }
            }
        }
    }

    //Ajouter une carte
    public void AddCardToScene(GameObject cardCompare, Player player)
    {
        for (int i = 0; i < 15; i++)
        {
            if (cartes[i].currentAmount == 0 && cartes[i].cardIndex == cardCompare.GetComponent<CardContainer>().cardData.cardIndex)
            {
                AddCardBasic(cartes[i], GameManager.GetInstance().selectedCard, player);
            }
            else if (cartes[i].currentAmount > 0 && cartes[i].cardIndex == cardCompare.GetComponent<CardContainer>().cardData.cardIndex && GameManager.GetInstance().activePlayer.canBuy)
            {
                if (cartes[i].currentAmount < GameManager.GetInstance().selectedCard.GetComponent<CardContainer>().cardData.maxNumCard)
                {
                    AddCardUpper(cartes[i], GameManager.GetInstance().selectedCard, player);
                }
            }
        }
    }

    //Ajouter une carte au dessus d'une autre
    private void AddCardUpper(CardStocker cardStocker, GameObject prefab, Player player)
    {
        for (int i = 0; i < CardLibrary.GetInstance().brutCardContainer.Count; i++)
        {
            if (CardLibrary.GetInstance().brutCardContainer[i].data.nameCard == GameManager.GetInstance().selectedCard.GetComponent<CardContainer>().cardData.nameCard)
            {
                player.cardObtained.Add(CardLibrary.GetInstance().brutCardContainer[i]);
                player.cardObtained.Last().owner = GameManager.GetInstance().activePlayer;
            }
        }
        GameObject obj = Instantiate(prefab, cardStocker.carteStock[cardStocker.currentAmount - 1].transform);
        cardStocker.carteStock.Add(obj.gameObject);
        GameObject baseObj = Instantiate(prefab, baseHand.transform);
        cartes[cardStocker.cardIndex].currentAmount++;
        GameManager.GetInstance().BuyUI.SetActive(false);
        obj.gameObject.GetComponent<Dissolve>().canDissolve = true;
        baseObj.gameObject.GetComponent<Dissolve>().canDissolve = true;
    }
    private void AddCardBasic(CardStocker cardStocker, GameObject prefab, Player player)
    {
        for (int i = 0; i < CardLibrary.GetInstance().brutCardContainer.Count; i++)
        {
            if (CardLibrary.GetInstance().brutCardContainer[i].data.nameCard == GameManager.GetInstance().selectedCard.GetComponent<CardContainer>().cardData.nameCard)
            {
                player.cardObtained.Add(CardLibrary.GetInstance().brutCardContainer[i]);
                player.cardObtained.Last().owner = GameManager.GetInstance().activePlayer;
            }
        }
        GameObject obj = Instantiate(prefab, handParent.transform);
        cardStocker.carteStock.Add(obj.gameObject);
        GameObject baseObj = Instantiate(prefab, baseHand.transform);
        cartes[cardStocker.cardIndex].currentAmount++;
        GameManager.GetInstance().BuyUI.SetActive(false);
        obj.gameObject.GetComponent<Dissolve>().canDissolve = true;
        baseObj.gameObject.GetComponent<Dissolve>().canDissolve = true;
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
