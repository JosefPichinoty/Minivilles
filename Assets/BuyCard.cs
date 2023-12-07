using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BuyCard : MonoBehaviour
{
    [SerializeField] private GameObject player1Hand, playerbase1;
    [SerializeField] private GameObject player2Hand, playerbase2;
    [SerializeField] private GameObject player3Hand, playerbase3;
    [SerializeField] private GameObject player4Hand, playerbase4;


    [SerializeField] private Player player1Data;
    [SerializeField] private Player player2Data;
    [SerializeField] private Player player3Data;
    [SerializeField] private Player player4Data;



    public void BuyEstablishmentCard()
    {
        if (GameManager.GetInstance().activePlayer == player1Data)
        {
            player1Hand.GetComponent<PlayerHand>().Buy();
            playerbase1.GetComponent<PlayerHand>().Buy();
            GameManager.GetInstance().activePlayer.canBuy = false;
        }
        else if(GameManager.GetInstance().activePlayer == player2Data)
        {
            player2Hand.GetComponent<PlayerHand>().Buy();
            playerbase2.GetComponent<PlayerHand>().Buy();
            GameManager.GetInstance().activePlayer.canBuy = false;

        }
        else if(GameManager.GetInstance().activePlayer == player3Data)
        {
            player3Hand.GetComponent<PlayerHand>().Buy();
            playerbase3.GetComponent<PlayerHand>().Buy();
            GameManager.GetInstance().activePlayer.canBuy = false;

        }
        else if(GameManager.GetInstance().activePlayer == player4Data)
        {
            player4Hand.GetComponent<PlayerHand>().Buy();
            playerbase4.GetComponent<PlayerHand>().Buy();
            GameManager.GetInstance().activePlayer.canBuy = false;

        }
    }

}
