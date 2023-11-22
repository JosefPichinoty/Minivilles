using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CardLibrary : MonoBehaviour
{
    public List<CardData> cards = new List<CardData>();

    private void Start()
    {
        Init();
    }

    void Init()
    {
        /*Card champsDeBle = new BlueCard("Champs de blé", 1, 1, 0, false, Card.typeCard.wheat);
        Card ferme = new BlueCard("Ferme", 1, 2, 0, false, Card.typeCard.animal);
        Card boulangerie = new GreenCard("Boulangerie", 1, 2, 3, false, Card.typeCard.shop);
        Card cafe = new RedCard("Café", 2, 3, 0, false, Card.typeCard.coffee);
        Card superette = new GreenCard("Supérette", 2, 4, 0, false, Card.typeCard.shop);
        Card foret = new BlueCard("Forêt", 3, 5, 0, false, Card.typeCard.industry);
        Card stade = new PurpleCard("Stade", 6, 6, 0, true, Card.typeCard.business);
        Card centreDAffaire = new PurpleCard("Centre d'affaires", 8, 6, 0, true, Card.typeCard.business);
        Card chaineDeTelevision = new PurpleCard("Chaîne de télévision", 7, 6, 0, true, Card.typeCard.business);
        Card fromagerie = new GreenCard("Fromagerie", 5, 7, 0, false, Card.typeCard.factory);
        Card fabriqueDeMeubles = new GreenCard("Fabrique de meubles", 3, 8, 0, false, Card.typeCard.factory);
        Card mine = new BlueCard("Mine", 6, 9, 0, false, Card.typeCard.industry);
        Card restaurant = new RedCard("Restaurant", 3, 9, 10, false, Card.typeCard.coffee);
        Card verger = new BlueCard("Verger", 3, 10, 0, false, Card.typeCard.wheat);
        Card marcheDeFruitsEtLegumes = new GreenCard("Marché de fruits et légumes", 2, 11, 12, false, Card.typeCard.wheat);
        
        
        cards.Add(new CardData(champsDeBle, 6));
        cards.Add(new CardData(ferme, 6));
        cards.Add(new CardData(boulangerie, 6));
        cards.Add(new CardData(cafe, 6));
        cards.Add(new CardData(superette, 6));
        cards.Add(new CardData(foret, 6));
        cards.Add(new CardData(stade, 6));
        cards.Add(new CardData(centreDAffaire, 6));
        cards.Add(new CardData(chaineDeTelevision, 6));
        cards.Add(new CardData(fromagerie, 6));
        cards.Add(new CardData(fabriqueDeMeubles, 6));
        cards.Add(new CardData(mine, 6));
        cards.Add(new CardData(restaurant, 6));
        cards.Add(new CardData(verger, 6));
        cards.Add(new CardData(marcheDeFruitsEtLegumes, 6));*/


        cards.Add(new CardData(new BlueCard("Champs de blé", 1, 1, 0, false, Card.typeCard.wheat), 6));
        cards.Add(new CardData(new BlueCard("Ferme", 1, 2, 0, false, Card.typeCard.animal), 6));
        cards.Add(new CardData(new GreenCard("Boulangerie", 1, 2, 3,false, Card.typeCard.shop), 6));
        cards.Add(new CardData(new RedCard("Café", 2, 3, 0, false, Card.typeCard.coffee), 6));
        cards.Add(new CardData(new GreenCard("Supérette", 2, 4, 0, false, Card.typeCard.shop), 6));
        cards.Add(new CardData(new BlueCard("Forêt", 3, 5, 0, false, Card.typeCard.industry), 6));
        cards.Add(new CardData(new PurpleCard("Stade", 6, 6, 0, true, Card.typeCard.business), 4));
        cards.Add(new CardData(new PurpleCard("Centre d'affaires", 8, 6, 0, true, Card.typeCard.business), 4));
        cards.Add(new CardData(new PurpleCard("Chaîne de télévision", 7, 6, 0, true, Card.typeCard.business), 4));
        cards.Add(new CardData(new GreenCard("Fromagerie", 5, 7, 0, false, Card.typeCard.factory), 6));
        cards.Add(new CardData(new GreenCard("Fabrique de meubles", 3, 8, 0, false, Card.typeCard.factory), 6));
        cards.Add(new CardData(new BlueCard("Mine", 6, 9, 0, false, Card.typeCard.industry), 6));
        cards.Add(new CardData(new RedCard("Restaurant", 3, 9, 10, false, Card.typeCard.coffee), 6));
        cards.Add(new CardData(new BlueCard("Verger", 3, 10, 0, false, Card.typeCard.wheat), 6));
        cards.Add(new CardData(new GreenCard("Marché de fruits et légumes", 2, 11, 12, false, Card.typeCard.wheat), 6));
    }
}

[System.Serializable]
public class CardData
{
    public CardData(Card pCard, int pCardLeft)
    {
        card = pCard;
        cardLeft = pCardLeft;
    }

    public Card card;
    public GameObject prefab;
    private int cardLeft;
}