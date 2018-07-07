
using UnityEngine;
using System.Collections;

public class GlobalStateManager : MonoBehaviour
{
    private int deadPlayers = 0;
    private int deadPlayerNumber = -1;
    LevelManager load = new LevelManager();
    public void PlayerDied (int playerNumber)
    {
       deadPlayers++;
        if (deadPlayers == 1)
            deadPlayerNumber = playerNumber;
        Invoke("CheckPlayersDeath", .3f); 
    }
    void CheckPlayersDeath()
    {
        // 1
        if (deadPlayers == 1)
        {
            // 2
            if (deadPlayerNumber == 1)
            {
                Debug.Log("Player 2 is the winner!");
                load.LoadLevel("P2");
                
            }
            else
            {
                Debug.Log("Player 1 is the winner!");
                load.LoadLevel("P1");
            }
            // 4
        }
        else
        {
            Debug.Log("The game ended in a draw!");
            load.LoadLevel("D");
        }
    }
}


