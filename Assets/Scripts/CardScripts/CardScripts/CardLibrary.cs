using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CardLibrary : MonoBehaviour 
{
    #region SINGLETON INSTANCE
    static private CardLibrary instance;

    static public CardLibrary GetInstance()
    {
        if (instance == null) instance = new CardLibrary();
        return instance;
    }

    private CardLibrary() : base() { }
    #endregion

    public List<CardData> cards = new List<CardData>();
    public List<CardData> monuments = new List<CardData>();

    public List<Card> brutCardContainer = new List<Card>();
    public List<Card> brutMonumentContainer = new List<Card>();

    public Card champsDeBle;
    public Card ferme;
    public Card boulangerie;
    public Card cafe;
    public Card superette;
    public Card foret;
    public Card stade;
    public Card centreDAffaire;
    public Card chaineDeTelevision;
    public Card fromagerie;
    public Card fabriqueDeMeubles;
    public Card mine;
    public Card restaurant;
    public Card verger;
    public Card marcheDeFruitsEtLegumes;

    public Card gare;
    public Card centreCommercial;
    public Card parcDAttraction;
    public Card tourRadio;

    private void Start()
    {
        if (instance != null)
        {
            Destroy(instance);
            return;
        }

        instance = this;

        Init();
    }

    void Init()
    {
        champsDeBle = new BlueCard(GetInstance().cards[0], Card.typeCard.wheat, false);
        ferme = new BlueCard(GetInstance().cards[1], Card.typeCard.animal, false);
        boulangerie = new GreenCard(GetInstance().cards[2], Card.typeCard.shop, false);
        cafe = new RedCard(GetInstance().cards[3], Card.typeCard.coffee, false);
        superette = new GreenCard(GetInstance().cards[4], Card.typeCard.shop, false);
        foret = new BlueCard(GetInstance().cards[5], Card.typeCard.industry, false);
        stade = new PurpleCard(GetInstance().cards[6], Card.typeCard.business, false);
        centreDAffaire = new PurpleCard(GetInstance().cards[7], Card.typeCard.business, false);
        chaineDeTelevision = new PurpleCard(GetInstance().cards[8], Card.typeCard.business, false);
        fromagerie = new GreenCard(GetInstance().cards[9], Card.typeCard.factory, false);
        fabriqueDeMeubles = new GreenCard(GetInstance().cards[10], Card.typeCard.factory, false);
        mine = new BlueCard(GetInstance().cards[11], Card.typeCard.industry, false);
        restaurant = new RedCard(GetInstance().cards[12], Card.typeCard.coffee, false);
        verger = new BlueCard(GetInstance().cards[13], Card.typeCard.wheat, false);
        marcheDeFruitsEtLegumes = new GreenCard(GetInstance().cards[14], Card.typeCard.wheat, false);

        gare = new OrangeCard(GetInstance().monuments[0], Card.typeCard.business, false);
        centreCommercial = new OrangeCard(GetInstance().monuments[1], Card.typeCard.business, false);
        parcDAttraction = new OrangeCard(GetInstance().monuments[2], Card.typeCard.business, false);
        tourRadio = new OrangeCard(GetInstance().monuments[3], Card.typeCard.business, false);

        brutCardContainer.Add(champsDeBle);
        brutCardContainer.Add(ferme);
        brutCardContainer.Add(boulangerie);
        brutCardContainer.Add(cafe);
        brutCardContainer.Add(superette);
        brutCardContainer.Add(foret);
        brutCardContainer.Add(stade);
        brutCardContainer.Add(centreDAffaire);
        brutCardContainer.Add(chaineDeTelevision);
        brutCardContainer.Add(fromagerie);
        brutCardContainer.Add(fabriqueDeMeubles);
        brutCardContainer.Add(mine);
        brutCardContainer.Add(restaurant);
        brutCardContainer.Add(verger);
        brutCardContainer.Add(marcheDeFruitsEtLegumes);

        brutMonumentContainer.Add(gare);
        brutMonumentContainer.Add(centreCommercial);
        brutMonumentContainer.Add(parcDAttraction);
        brutMonumentContainer.Add(tourRadio);

        foreach (Player player in PlayerManager.GetInstance().playerList)
        {
            player.monumentList.Add((OrangeCard)gare);
            player.monumentList.Add((OrangeCard)centreCommercial);
            player.monumentList.Add((OrangeCard)parcDAttraction);
            player.monumentList.Add((OrangeCard)tourRadio);
        }
    }
    


    //cards.Add(new BlueCard("Champs de blé", 1, 1, 0, false, Card.typeCard.wheat));
    //cards.Add(new BlueCard("Ferme", 1, 2, 0, false, Card.typeCard.animal));
    //cards.Add(new GreenCard("Boulangerie", 1, 2, 3,false, Card.typeCard.shop));
    //cards.Add(new RedCard("Café", 2, 3, 0, false, Card.typeCard.coffee));
    //cards.Add(new GreenCard("Supérette", 2, 4, 0, false, Card.typeCard.shop));
    //cards.Add(new BlueCard("Forêt", 3, 5, 0, false, Card.typeCard.industry));
    //cards.Add(new PurpleCard("Stade", 6, 6, 0, true, Card.typeCard.business));
    //cards.Add(new PurpleCard("Centre d'affaires", 8, 6, 0, true, Card.typeCard.business));
    //cards.Add(new PurpleCard("Chaîne de télévision", 7, 6, 0, true, Card.typeCard.business));
    //cards.Add(new GreenCard("Fromagerie", 5, 7, 0, false, Card.typeCard.factory));
    //cards.Add(new GreenCard("Fabrique de meubles", 3, 8, 0, false, Card.typeCard.factory));
    //cards.Add(new BlueCard("Mine", 6, 9, 0, false, Card.typeCard.industry));
    //cards.Add(new RedCard("Restaurant", 3, 9, 10, false, Card.typeCard.coffee));
    //cards.Add(new BlueCard("Verger", 3, 10, 0, false, Card.typeCard.wheat));
    //cards.Add(new GreenCard("Marché de fruits et légumes", 2, 11, 12, false, Card.typeCard.wheat));
}

//[System.Serializable]
//public class CardData
//{
//    public CardData(Card pCard)
//    {
//        card = pCard;
//    }
//
//  public Card card;
//  public GameObject prefab;
//  private int cardLeft;
//