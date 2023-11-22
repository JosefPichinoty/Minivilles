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

    public int turn;

    void Start()
    {
        
    }

    private void PrepareGame()
    {
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
}
