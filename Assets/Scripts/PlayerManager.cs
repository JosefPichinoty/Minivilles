using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    #region SINGLETON INSTANCE
    static private PlayerManager instance;

    static public PlayerManager GetInstance()
    {
        if (instance == null) instance = new PlayerManager();
        return instance;
    }

    private PlayerManager() : base() { }
    #endregion

    public int numPlayers = 2;
    public List<Player> playerList = new List<Player>();
    public Player activePlayer;

    void Start()
    {
        if (instance != null)
        {
            Destroy(instance);
            return;
        }

        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
