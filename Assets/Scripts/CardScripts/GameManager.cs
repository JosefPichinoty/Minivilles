using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public Player activePlayer;

    public GameObject selectedCard;

    public int turn;

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

    void Update()
    {
        
    }

    public void SetSellectedCard() {
    
    }
}
