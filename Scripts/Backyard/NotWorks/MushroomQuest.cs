using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomQuest : MonoBehaviour
{
    public bool questM;
    public bool isGame;
    public GameObject SQBG2;
    public GameObject CBG;
    private MainQuest MQ;
    public void Start()
    {
        MQ = GameObject.FindGameObjectWithTag("Player").GetComponent<MainQuest>();
        SQBG2.SetActive(false);
        CBG.SetActive(false);
    }
    public void Update()
    {
        if (isGame)
        {
            SQBG2.SetActive(true);
            if (MQ.AfterQuestM)
            {
                CBG.SetActive(true);
                SQBG2.SetActive(false);
            }
        }
    }
}
