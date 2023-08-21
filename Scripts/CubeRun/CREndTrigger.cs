using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CREndTrigger : MonoBehaviour
{
    public CRGameManager GM;
    private void OnTriggerEnter()
    {
        GM.CompleteLevel();
    }
}
