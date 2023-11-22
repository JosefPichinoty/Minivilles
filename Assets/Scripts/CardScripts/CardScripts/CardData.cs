using UnityEngine;

[CreateAssetMenu(fileName = "newCard", menuName = "cardContainer/card")]
public class CardData : ScriptableObject
{
    public string nameCard;
    protected Player owner;
    public int valueMoney;
    public int valueDice;
    public int secondValueDice;
    public int maxNumCard;
    public bool onlyCard;
}
