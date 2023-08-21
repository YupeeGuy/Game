using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChibiQuest : MonoBehaviour
{
    public bool questCC;
    public string ObjectTag;
    public bool MissObjects;
    public GameObject SQBG1;
    public GameObject SQBG2;
    public GameObject CBG;
    private MainQuest MQ;
    public void Start()
    {
        MQ = GameObject.FindGameObjectWithTag("Player").GetComponent<MainQuest>();
        SQBG1.SetActive(false);
        SQBG2.SetActive(false); 
        CBG.SetActive(false);
    }
    public void Update()
    {
        if (questCC)
        {
            SQBG1.SetActive(true);            
        }
        if (MissObjects)
        {
            SQBG1.SetActive(false);
            SQBG2.SetActive(true);
            if (MQ.AfterQuestCC)
            {
                CBG.SetActive(true);
                SQBG2.SetActive(false);
            }
        }
    }
}
