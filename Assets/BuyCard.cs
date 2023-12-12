using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BuyCard : MonoBehaviour
{
    [SerializeField] private GameObject player1Hand;
    [SerializeField] private GameObject player2Hand;
    [SerializeField] private GameObject player3Hand;
    [SerializeField] private GameObject player4Hand;


    [SerializeField] private Player player1Data;
    [SerializeField] private Player player2Data;
    [SerializeField] private Player player3Data;
    [SerializeField] private Player player4Data;



    public void BuyEstablishmentCard()
    {
        if (GameManager.GetInstance().activePlayer == player1Data)
        {
            player1Hand.GetComponent<PlayerHand>().Buy();
        }
        else if(GameManager.GetInstance().activePlayer == player2Data)
        {
            player2Hand.GetComponent<PlayerHand>().Buy();

        }
        else if(GameManager.GetInstance().activePlayer == player3Data)
        {
            player3Hand.GetComponent<PlayerHand>().Buy();

        }
        else if(GameManager.GetInstance().activePlayer == player4Data)
        {
            player4Hand.GetComponent<PlayerHand>().Buy();

        }
    }

}
