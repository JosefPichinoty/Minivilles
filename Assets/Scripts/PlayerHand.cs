using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerHand : MonoBehaviour
{
    private Transform handParent;
    [SerializeField] private List<CardStocker> cartes = new List<CardStocker>();


    // Start is called before the first frame update
    void Start()
    {
        handParent = gameObject.GetComponent<Transform>().GetChild(0).GetChild(0).GetComponent<Transform>();
        for (int i = 0; i < 15; i++)
        {
            cartes.Add(new CardStocker(i));
        }
    }
    public void Buy()
    {
        for (int i = 0; i < 15; i++)
        {
            if (cartes[i].currentAmount == 0 && cartes[i].cardIndex == GameManager.GetInstance().selectedCard.GetComponent<CardContainer>().cardData.cardIndex)
            {
                //if (GameManager.GetInstance().activePlayer.money >= GameManager.GetInstance().selectedCard.GetComponent<CardContainer>().cardData.valueMoney)
                //{
                AddCardBasic(cartes[i], GameManager.GetInstance().selectedCard);
                //GameManager.GetInstance().activePlayer.money -= GameManager.GetInstance().selectedCard.GetComponent<CardContainer>().cardData.valueMoney;
                //}
            }
            else if(cartes[i].currentAmount > 0 && cartes[i].cardIndex == GameManager.GetInstance().selectedCard.GetComponent<CardContainer>().cardData.cardIndex)
            {
                //if (cartes[i].currentAmount < GameManager.GetInstance().selectedCard.GetComponent<CardContainer>().cardData.maxNumCard)
                //{
                //    print("rien2");
                    AddCardUpper(cartes[i], GameManager.GetInstance().selectedCard);
                //}
            }
        }
    }

    private void AddCardUpper(CardStocker cardStocker, GameObject prefab)
    {
        for (int i = 0; i < CardLibrary.GetInstance().brutCardContainer.Count; i++)
        {
            if (CardLibrary.GetInstance().brutCardContainer[i].data.nameCard == GameManager.GetInstance().selectedCard.GetComponent<CardContainer>().cardData.nameCard)
            {
                GameManager.GetInstance().activePlayer.cardObtained.Add(CardLibrary.GetInstance().brutCardContainer[i]);
            }
        }
        GameObject obj = Instantiate(prefab, cardStocker.carteStock[cardStocker.currentAmount - 1].transform);
        cardStocker.carteStock.Add(obj.gameObject);
        cartes[cardStocker.cardIndex].currentAmount++;
        GameManager.GetInstance().BuyUI.SetActive(false);
        prefab.GetComponent<Dissolve>().ActiveShader();
    }
    private void AddCardBasic(CardStocker cardStocker, GameObject prefab)
    {
        for (int i = 0; i < CardLibrary.GetInstance().brutCardContainer.Count; i++)
        {
            if (CardLibrary.GetInstance().brutCardContainer[i].data.nameCard == GameManager.GetInstance().selectedCard.GetComponent<CardContainer>().cardData.nameCard)
            {
                GameManager.GetInstance().activePlayer.cardObtained.Add(CardLibrary.GetInstance().brutCardContainer[i]);
            }

        }
        GameObject obj = Instantiate(prefab, handParent.transform);
        cardStocker.carteStock.Add(obj.gameObject);
        cartes[cardStocker.cardIndex].currentAmount++;
        GameManager.GetInstance().BuyUI.SetActive(false);
        prefab.GetComponent<Dissolve>().ActiveShader();
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
