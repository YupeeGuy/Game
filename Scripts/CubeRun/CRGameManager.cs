using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CRGameManager : MonoBehaviour
{
    public CRMove move;
    public Transform player;
    public Transform start;
    public bool gameHasEnded = false;
    public bool gameHasComplete = false;
    public float restartDelay = 1f;
    public void CompleteLevel()
    {
        if (gameHasComplete == false)
        {
            gameHasComplete = true;
        }
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }
    public void Restart()
    {
        player.position = start.position;
        player.rotation = start.rotation;
        if (player.position == start.position)
        {
            move.enabled = true;
            gameHasEnded = false;
        }
    }
}
