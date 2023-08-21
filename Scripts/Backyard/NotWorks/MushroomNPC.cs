using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomNPC : MonoBehaviour
{
    private bool dialog0;
    private bool dialog1;
    private bool dialog2;
    private bool dialog3;
    private MushroomQuest MP;
    private MainQuest MQ;
    private WalkOutside Cat;
    public CRGameManager GM;
    public GameObject CubeRun;
    public GameObject MC;
    public GameObject QC;
    public GameObject BG0;
    public GameObject BG1;
    public GameObject BG2;
    public GameObject BG3;
    void Start()
    {
        MP = GameObject.FindGameObjectWithTag("Player").GetComponent<MushroomQuest>();
        MQ = GameObject.FindGameObjectWithTag("Player").GetComponent<MainQuest>();
        Cat = GameObject.FindGameObjectWithTag("Player").GetComponent<WalkOutside>();
        BG0.SetActive(false);
        BG1.SetActive(false);
        BG2.SetActive(false);
        MP.isGame = false;
        MC.SetActive(true);
        QC.SetActive(false);
        CubeRun.SetActive(false);
    }
    void Update()
    {
        GameObject MissTagScanner = GameObject.FindGameObjectWithTag("Player");
        if (Input.GetKeyDown(KeyCode.E) & Vector3.Distance(transform.position, MissTagScanner.transform.position) < 2)
        {
            if (!MQ.quest)
            {
                dialog0 = true;
            }
            if (MQ.quest & !MP.questM)
            {
                if (!MQ.AfterQuestM)
                {
                    dialog1 = true;
                }                    
            }
            if (MQ.AfterQuestM)
            {
                dialog3 = true;
            }
        }
        if (MP.isGame & MP.questM)
        {
            dialog2 = true;
        }
        if (dialog0 & !MQ.quest)
        {
            StartDialog0();
        }
        if (dialog1 & MQ.quest)
        {
            StartDialog1();
        }        
        if (dialog2 & GM.gameHasComplete)
        {
            StartDialog2();
        }
        if (MQ.AfterQuestM & dialog3)
        {
            StartDialog3();
        }
    }
    public void StartDialog0()
    {
        BG0.SetActive(true);
        if (Input.GetKeyDown(KeyCode.Q) & dialog0)
        {
            dialog0 = false;
        }
        if (dialog0 == false)
        {
            BG0.SetActive(false);
        }
    }
    public void StartDialog1()
    {
        BG1.SetActive(true);
        if (Input.GetKeyDown(KeyCode.Q) & dialog1)
        {
            dialog1 = false;
            MP.questM = true;
            MP.isGame = true;
            MC.SetActive(false);
            QC.SetActive(true);
            CubeRun.SetActive(true);
            Cat.abe.enabled = false;
        }
        if (dialog1 == false)
        {
            BG1.SetActive(false);
        }
    }
    public void StartDialog2()
    {
        BG2.SetActive(true);
        MC.SetActive(true);
        QC.SetActive(false);
        CubeRun.SetActive(false);
        Cat.abe.enabled = true;
        if (Input.GetKeyDown(KeyCode.Q) & dialog2)
        {
            dialog2 = false;
            MQ.AfterQuestM = true;
            MP.questM = false;
        }
        if (dialog2 == false)
        {
            BG2.SetActive(false);
        }
    }
    public void StartDialog3()
    {
        BG3.SetActive(true);
        if (Input.GetKeyDown(KeyCode.Q) & dialog3)
        {
            dialog3 = false;
        }
        if (dialog3 == false)
        {
            BG3.SetActive(false);
        }
    }
}
