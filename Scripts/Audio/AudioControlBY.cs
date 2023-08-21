using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControlBY : MonoBehaviour
{
    private MainQuest MQ;
    private MushroomQuest MNPC;
    private ChibiQuest CQ;
    private LeafQuest LQ;
    public GameObject source1;
    public GameObject source2;
    public GameObject source3;
    public GameObject source4;
    public GameObject source5;
    void Start()
    {
        MQ = GameObject.FindGameObjectWithTag("Player").GetComponent<MainQuest>();
        MNPC = GameObject.FindGameObjectWithTag("Player").GetComponent<MushroomQuest>();
        CQ = GameObject.FindGameObjectWithTag("Player").GetComponent<ChibiQuest>();
        LQ = GameObject.FindGameObjectWithTag("Player").GetComponent<LeafQuest>();
        source1.SetActive(true);
        source2.SetActive(false);
        source3.SetActive(false);
        source4.SetActive(false);
        source5.SetActive(false);
    }
    void Update()
    {
        if (MQ.quest)
        {
            source1.SetActive(false);
            source2.SetActive(true);
            if (MNPC.questM & MNPC.isGame)
            {
                source2.SetActive(false);                
            }
            if (MQ.AfterQuestM)
            {
                source2.SetActive(true);
            }
            if (CQ.questCC)
            {
                source2.SetActive(false);
                source3.SetActive(true);                
            }
            if (MQ.AfterQuestCC)
            {
                source3.SetActive(false);
                source2.SetActive(true);
            }
            if (LQ.questL)
            {
                source2.SetActive(false);
                source4.SetActive(true);
            }
            if (MQ.AfterQuestL)
            {
                source4.SetActive(false);
                source2.SetActive(true);
            }
        }
        if (MQ.TheEnd & MQ.ED)
        {
            source2.SetActive(false);
            source5.SetActive(true);
        }        
    }
}
