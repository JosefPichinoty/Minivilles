using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Card : MonoBehaviour 
    {
    public Card(CardData pData, typeCard pType)
    {
        data = pData;
        type = pType;
    }

    protected CardData data;
    protected Player owner;

    public typeCard type;

    public enum typeCard
    {
        wheat,
        animal,
        shop,
        coffee,
        industry,
        business,
        factory,
        fruits
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void CardBought(Player player)
    {
        owner = player;
    }

    public virtual void Effect()
    {

    }
}