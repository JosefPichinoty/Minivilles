using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class BuyButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseMenu()
    {
        GameManager.GetInstance().BuyUI.SetActive(false);
    }

    public void BuyCard()
    {
        print(GameManager.GetInstance().selectedCard);
        //PlayerHand.Buy(GameManager.GetInstance().selectedCard);
    }
}
