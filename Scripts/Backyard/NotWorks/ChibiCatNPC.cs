using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChibiCatNPC : MonoBehaviour
{
    private bool dialog0;
    private bool dialog1;
    private bool dialog2;
    private bool dialog3;
    private bool dialog4;
    public string missTag;
    private ChibiQuest MP;
    private MainQuest MQ;
    public GameObject AQObject;
    public GameObject BG0;
    public GameObject BG1;
    public GameObject BG2;
    public GameObject BG3;
    public GameObject BG4;
    void Start()
    {
        MP = GameObject.FindGameObjectWithTag("Player").GetComponent<ChibiQuest>();
        MQ = GameObject.FindGameObjectWithTag("Player").GetComponent<MainQuest>();
        BG0.SetActive(false);
        BG1.SetActive(false);
        BG2.SetActive(false);
        BG3.SetActive(false);
        MP.MissObjects = false;
        AQObject.SetActive(false);
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
            if (MQ.quest & !MP.questCC) 
            {
                dialog1 = true;
            }            
            if (!MP.MissObjects & MP.questCC)
            {
                dialog2 = true;
            }
            if (MP.MissObjects & MP.questCC)
            {
                dialog3 = true;
            }
            if (MQ.AfterQuestCC)
            {
                dialog4 = true;
            }
        }
        if (dialog0 & !MQ.quest)
        {
            StartDialog0();
        }
        if (dialog1 & !MP.MissObjects)
        {
            StartDialog1();
        }
        if (dialog2 & !MP.MissObjects)
        {
            if (MQ.quest)
            {
                StartDialog2();
            }
        }
        if (dialog3 & MP.MissObjects)
        {
            StartDialog3();
        }
        if (dialog4 & MQ.AfterQuestCC)
        {
            StartDialog4();
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
            MP.questCC = true;
            MP.ObjectTag = missTag;
            BG1.SetActive(false);
        }
    }
    public void StartDialog2()
    {
        BG2.SetActive(true);
        if (Input.GetKeyDown(KeyCode.Q) & dialog2)
        {
            dialog2 = false;           
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
            MP.questCC = false;
            MQ.AfterQuestCC = true;
            AQObject.SetActive(true);
        }
        if (dialog3 == false)
        {
            BG3.SetActive(false);
        }
    }
    public void StartDialog4()
    {
        BG4.SetActive(true);
        if (Input.GetKeyDown(KeyCode.Q) & dialog4)
        {
            dialog4 = false;
        }
        if (dialog4 == false)
        {
            BG4.SetActive(false);
        }
    }
}
