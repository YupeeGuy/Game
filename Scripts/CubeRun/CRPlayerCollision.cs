using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CRPlayerCollision : MonoBehaviour
{
    public CRMove move;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstical")
        {
            move.enabled = false;
            FindObjectOfType<CRGameManager>().EndGame();
        }
        if (collision.collider.tag == "Finish")
        {
            FindObjectOfType<CRGameManager>().CompleteLevel();
        }
    }
}
