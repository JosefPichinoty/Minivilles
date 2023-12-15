using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UIElements;

public class Card
{
    public Card(CardData pData, typeCard pType)
    {
        data = pData;
        type = pType;
    }

    public bool buyable;
    public CardData data;
    public Player owner;
    public DiceThrow dice;
    public GameManager _gm;

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

    public virtual void CardBought(Player player) //Cette fonction d�finit le poss�sseur de la carte.
    {
        owner = player;
    }

    public virtual void Effect(int nombre, ref bool didEffect) //Cette fonction sera overrid�e par ces enfants et activera l'effet des cartes.
    {
        ChangeStateCard();
    }

    public virtual void CommercialCenterEffect() //Cette fonction donne une pi�ce au joueur � chaque fois qu'elle est appel�e
    {
        if (owner.bonusMoney == true)
        {
            owner.money++;
        }
    }

    public void ChangeStateCard() //Permet de v�rifier si le monument est achetable ou non
    {
        foreach (Player player in PlayerManager.GetInstance().playerList)
        {
            foreach (OrangeCard monument in player.monumentList)
            {
                if (monument.owner.money >= monument.data.valueMoney)
                {
                    monument.buyable = true;
                    GameManager.GetInstance().CheckMonuments();
                }
                else
                {
                    monument.buyable = false;
                }
            }

        }
    }
}