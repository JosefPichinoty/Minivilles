using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonumentManager : MonoBehaviour
{
    public GameObject player1Monument, playerBase1Monu;
    public GameObject player2Monument, playerBase2Monu;
    public GameObject player3Monument, playerBase3Monu;
    public GameObject player4Monument, playerBase4Monu;

    public Player player1;
    public Player player2;
    public Player player3;
    public Player player4;

    public void BuyMonument(int ID)
    {
        if (GameManager.GetInstance().activePlayer == player1)
        {
            if (ID == 1)
            {
                player1Monument.transform.GetChild(0);
            }
            else if (ID == 2)
            {

            }
            else if (ID == 3)
            {

            }
            else if (ID == 4)
            {

            }
        }
        else if (GameManager.GetInstance().activePlayer == player2)
        {

        }
        else if (GameManager.GetInstance().activePlayer == player3)
        {

        }
        else if (GameManager.GetInstance().activePlayer == player4)
        {

        }
    }
}
