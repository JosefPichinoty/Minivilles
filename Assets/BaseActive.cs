using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseActive : MonoBehaviour
{
    [SerializeField] private GameObject basep1;
    [SerializeField] private GameObject basep2;
    [SerializeField] private GameObject basep3;
    [SerializeField] private GameObject basep4;
    
    [SerializeField] private Player player1;
    [SerializeField] private Player player2;
    [SerializeField] private Player player3;
    [SerializeField] private Player player4;
    

    public void changeTurnUI()
    {
        if (GameManager.GetInstance().activePlayer == PlayerManager.GetInstance().player1)
        {
            basep1.SetActive(true);
            basep2.SetActive(false);
            basep3.SetActive(false);
            basep4.SetActive(false);
        }
        if (GameManager.GetInstance().activePlayer == PlayerManager.GetInstance().player2)
        {
            basep1.SetActive(false);
            basep2.SetActive(true);
            basep3.SetActive(false);
            basep4.SetActive(false);
        }
        if (GameManager.GetInstance().activePlayer == PlayerManager.GetInstance().player3)
        {
            basep1.SetActive(false);
            basep2.SetActive(false);
            basep3.SetActive(true);
            basep4.SetActive(false);
        }
        if (GameManager.GetInstance().activePlayer == PlayerManager.GetInstance().player4)
        {
            basep1.SetActive(false);
            basep2.SetActive(false);
            basep3.SetActive(false);
            basep4.SetActive(true);
        }

    }
}   
    