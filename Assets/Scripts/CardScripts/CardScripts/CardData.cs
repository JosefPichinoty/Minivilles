using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "newCard", menuName = "cardContainer/card")]
public class CardData : ScriptableObject //On d�finit toutes les propri�t�s des cartes dans l'inspecteur
{
    public string nameCard;
    protected Player owner;
    public Dice dice;
    public int valueMoney;
    public int valueDice;
    public int secondValueDice;
    public int maxNumCard;
    public int numCard;
    public bool onlyCard;
    public int cardIndex;
}
