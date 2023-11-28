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

    public int numPlayers = 2;
    public List <Player> playerList = new List<Player>();
    public Player activePlayer;

    public GameObject BuyUI;

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

        for (int i = 0; i < numPlayers; i++)
        {
            Player player = new Player();
            player.name = "player_" + (i + 1).ToString();
            playerList.Add(player);
        }
    }

    void Update()
    {
        
    }

    public void SetSellectedCard() {
    
    }
}
