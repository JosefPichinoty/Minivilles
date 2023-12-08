using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    #region SINGLETON INSTANCE
    static private PlayerManager instance;

    static public PlayerManager GetInstance()
    {
        if (instance == null)
        {
            instance = new PlayerManager();
        }
        return instance;
    }

    private PlayerManager() : base() { }
    #endregion

    [HideInInspector] int numPlayers = 4;
    public List<Player> playerList = new List<Player>();

    public Player player1;
    public Player player2;
    public Player player3;
    public Player player4;

    [SerializeField]
    GameObject playerIndicator;
    [SerializeField]
    private Sprite[] playerImages;
    int playerCounter = 0;

    [SerializeField]
    public GameObject NotifPanel;

    public Notification notif;


    [SerializeField]
    public DiceThrow dice;


    void Start()
    {
        if (instance != null)
        {
            Destroy(instance);
            return;
        }

        //NotifPanel.SetActive(false);
        
        instance = this;

        notif = NotifPanel.GetComponent<Notification>();

        CreationPlayers();
    }


    void Update()
    {
    }

    void CreationPlayers()
    {
        if (numPlayers == 1)
        {
            //PAS ENCORE POSSIBLE SANS IA
        }
        if (numPlayers == 2)
        {
            playerList.Add(player1);
            playerList.Add(player2);
        }
        if (numPlayers == 3)
        {
            playerList.Add(player1);
            playerList.Add(player2);
            playerList.Add(player3);
        }
        if (numPlayers == 4)
        {
            playerList.Add(player1);
            playerList.Add(player2);
            playerList.Add(player3);
            playerList.Add(player4);
        }

        GameManager.GetInstance().activePlayer = playerList[0];
        playerList[0].canThrow = true;
        playerList[0].playerTurn = true;
        playerList[0].canBuy = true;
    }

    void RefreshListPlayers()
    {
        if (GameManager.GetInstance().activePlayer.doubleTurn == false)
        {
            Player stockPlayer = playerList[0];
            playerList.RemoveAt(0);
            playerList.Add(stockPlayer);
        }
        else
        {
            GameManager.GetInstance().activePlayer.doubleTurn = false;
        }
    }

    public void ChangeTurn()
    {
        if (GameManager.GetInstance().activePlayer.rePlay)
        {
            playerIndicator.SetActive(true);
            playerCounter++;
            playerIndicator.GetComponent<UnityEngine.UI.Image>().sprite = playerImages[playerCounter];
            if(playerCounter == 3)
            {
                playerCounter = 0;
            }
            if (playerIndicator.GetComponent<Animator>().GetBool("endAnim"))
            {
                playerIndicator.SetActive(false);

            }


            playerList[0].BecomeActivePlayer();
            playerList[0].canThrow = true;
            playerList[0].playerTurn = true;
            playerList[0].canBuy = true;
            MoneyText.GetInstance().ChangeText();
            dice.resetDice();
        }
        else
        {
            playerIndicator.SetActive(true);
            playerCounter++;
            playerIndicator.GetComponent<UnityEngine.UI.Image>().sprite = playerImages[playerCounter];
            if (playerCounter == 3)
            {
                playerCounter = 0;
            }



            playerList[0].playerTurn = false;
            RefreshListPlayers();
            playerList[0].BecomeActivePlayer();
            playerList[0].canThrow = true;
            playerList[0].playerTurn = true;
            playerList[0].canBuy = true;
            Debug.Log(playerList[0].playerName);
            MoneyText.GetInstance().ChangeText();
            GameManager.GetInstance().activePlayer.Turn();
            dice.resetDice();
        }
    }



    /*public void CheckCardEffect()
    {
        foreach (Player player in playerList)
        {
            if (player.playerTurn)
            {
                foreach (GreenCard greenCard in player.cardObtained)
                {
                    greenCard.Effect();
                }

                foreach (PurpleCard purpleCard in player.cardObtained)
                {
                    purpleCard.Effect();
                }
            }
            else if (!player.playerTurn)
            {
                Debug.Log(player.cardObtained.Any(c => c.data.nameCard == "Caf�" || c.data.nameCard == "Restaurant"));
                for (int i = 0; i < player.cardObtained.Count; i++)
                {
                    if (player.cardObtained[i].data.nameCard == "Caf�" || player.cardObtained[i].data.nameCard == "Restaurant")
                    {
                        Debug.Log("pussy");
                    }
                }
                //foreach (RedCard redCard in player.cardObtained)
                //{
                //    redCard.Effect();
                //}
            }

            foreach (BlueCard blueCard in player.cardObtained)
            {
                blueCard.Effect();
            }
        }
    }*/

    public void CheckCardEffect(int nombre)
    {
        bool didEffect = false;
        foreach (Player player in playerList)
        {
            foreach (Card card in player.cardObtained)
            {
                if (player.playerTurn)
                {
                    if (card is GreenCard)
                    {
                        card.Effect(nombre,  ref didEffect);
                    }
                    if (card is PurpleCard)
                    {
                        card.Effect(nombre, ref didEffect);
                    }
                }
                else if (!player.playerTurn)
                {
                    if (card is RedCard)
                    {
                        card.Effect(nombre, ref didEffect);
                    }
                }
                if (card is BlueCard)
                {
                    card.Effect(nombre, ref didEffect);
                }
            }
            if (didEffect)
            {
                NotifPanel.GetComponent<Notification>().showMoneyNotif();
            }

        }

    }
}
