using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{

    #region SINGLETON INSTANCE
    static private GameManager instance;

    static public GameManager GetInstance()
    {
        if (instance == null) instance = new GameManager();
        return instance;
    }

    private GameManager() : base() { }
    #endregion

    public GameObject BuyUI;

    [SerializeField]
    public DiceThrow dice;

    public Player activePlayer;

    public GameObject selectedCard;

    public GameObject[] allCards;

    public int moneyGained;


    public GameObject[] monumentsGameObjects;

    public bool isDissolving ;

    public int turn;

    public GameObject firstSwitchCard;
    public GameObject secondSwitchCard;

    void Start()
    {
        InitGame();
    }

    private void InitGame()
    {
        if (instance != null)
        {
            Destroy(instance);
            return;
        }

        instance = this;
    }

    public void CheckMonuments()
    {
        foreach (Player player in PlayerManager.GetInstance().playerList)
        {
            foreach (OrangeCard monument in player.monumentList)
            {
                if (monument.owner.money >= monument.data.valueMoney)
                {
                    //Debug.Log("la carte" + monument + " est bien");
                    monument.buyable = true;
                }
                else
                {
                    //Debug.Log("la carte" + monument + " est mal");
                    monument.buyable = false;
                }
            }
        }
        
        foreach (Player player in PlayerManager.GetInstance().playerList)
        {
            for (int i = 0; i < player.monumentList.Count; i++)
            {
;               //Debug.Log("la carte" + monumentsGameObjects[i] + " est achetable");
                if (player.monumentList[i].buyable)
                {
                    monumentsGameObjects[i].GetComponent<Button>().interactable = true;
                    //Debug.Log("la carte" + monumentsGameObjects[i] + " est achetable");
                }
            }
        }

        
        //PlayerManager.GetInstance().player1.BecomeActivePlayer();
    }

    void Update()
    {
        //CheckMonuments();
        CheckMonumentsToBeBuy();
        Notification.GetInstance().moneyGained = moneyGained;
    }

    void CheckMonumentsToBeBuy()
    {
        foreach(GameObject monument in monumentsGameObjects)
        {
            if (monument.GetComponent<CardContainer>().cardData.valueMoney > activePlayer.money && monument.GetComponent<CardContainer>().monumentOwned == false)
            {
                monument.GetComponent<Button>().interactable = false;
            }
            else
            {
                monument.GetComponent<Button>().interactable = true;
            }
        }
    }

    public void SetSellectedCard() {
    
    }
}
