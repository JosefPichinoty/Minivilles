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

    void Init() //On crée une instance de chaque carte et on l'ajoute à une liste qui sert de dictionnaire.
    {
        champsDeBle = new BlueCard(GetInstance().cards[0], Card.typeCard.wheat);
        ferme = new BlueCard(GetInstance().cards[1], Card.typeCard.animal);
        boulangerie = new GreenCard(GetInstance().cards[2], Card.typeCard.shop);
        cafe = new RedCard(GetInstance().cards[3], Card.typeCard.coffee);
        superette = new GreenCard(GetInstance().cards[4], Card.typeCard.shop);
        foret = new BlueCard(GetInstance().cards[5], Card.typeCard.industry);
        stade = new PurpleCard(GetInstance().cards[6], Card.typeCard.business);
        centreDAffaire = new PurpleCard(GetInstance().cards[7], Card.typeCard.business);
        chaineDeTelevision = new PurpleCard(GetInstance().cards[8], Card.typeCard.business);
        fromagerie = new GreenCard(GetInstance().cards[9], Card.typeCard.factory);
        fabriqueDeMeubles = new GreenCard(GetInstance().cards[10], Card.typeCard.factory);
        mine = new BlueCard(GetInstance().cards[11], Card.typeCard.industry);
        restaurant = new RedCard(GetInstance().cards[12], Card.typeCard.coffee);
        verger = new BlueCard(GetInstance().cards[13], Card.typeCard.wheat);
        marcheDeFruitsEtLegumes = new GreenCard(GetInstance().cards[14], Card.typeCard.wheat);

        gare = new OrangeCard(GetInstance().monuments[0], Card.typeCard.business);
        centreCommercial = new OrangeCard(GetInstance().monuments[1], Card.typeCard.business);
        parcDAttraction = new OrangeCard(GetInstance().monuments[2], Card.typeCard.business);
        tourRadio = new OrangeCard(GetInstance().monuments[3], Card.typeCard.business);

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
            gare.owner = player;
            player.monumentList.Add((OrangeCard)gare);
            centreCommercial.owner = player;
            player.monumentList.Add((OrangeCard)centreCommercial);
            parcDAttraction.owner = player;
            player.monumentList.Add((OrangeCard)parcDAttraction);
            tourRadio.owner = player;
            player.monumentList.Add((OrangeCard)tourRadio);
        }
    }
}