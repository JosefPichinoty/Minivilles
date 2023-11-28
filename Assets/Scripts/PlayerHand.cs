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
    public void Buy(GameObject prefab)
    {
        for (int i = 0; i < 15; i++)
        {
            if (cartes[i].currentAmount == 0 && cartes[i].cardIndex == prefab.GetComponent<CardContainer>().cardData.cardIndex)
            {
                AddCardBasic(cartes[i], prefab);
                print("rien");
            }
            else if(cartes[i].currentAmount > 0 && cartes[i].cardIndex == prefab.GetComponent<CardContainer>().cardData.cardIndex)
            {
                if (cartes[i].currentAmount < prefab.GetComponent<CardContainer>().cardData.maxNumCard)
                {
                    print("rien2");
                    AddCardUpper(cartes[i], prefab);
                }
            }
        }
    }

    private void AddCardUpper(CardStocker cardStocker, GameObject prefab)
    {
        print("Au dessus");
        print("Au dessus = " + cardStocker.carteStock[cardStocker.currentAmount - 1].name);
        GameObject obj = Instantiate(prefab, cardStocker.carteStock[cardStocker.currentAmount - 1].transform);
        cardStocker.carteStock.Add(obj.gameObject);
        cartes[cardStocker.cardIndex].currentAmount++;
    }
    private void AddCardBasic(CardStocker cardStocker, GameObject prefab)
    {
        GameObject obj = Instantiate(prefab, handParent.transform);
        Debug.Log("prefab = " + obj);
        cardStocker.carteStock.Add(obj.gameObject);
        cartes[cardStocker.cardIndex].currentAmount++;
        print("En dessous = " + cardStocker.cardIndex);
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
