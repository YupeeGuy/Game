using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafNPC : MonoBehaviour
{
    private bool dialog0;
    private bool dialog1;
    private bool dialog2;
    private bool dialog3;
    private MainQuest MQ;
    private LeafQuest LQ;
    public GameObject Leaf;
    public GameObject Pos1;
    public GameObject BG0;
    public GameObject BG1;
    public GameObject BG2;
    public GameObject BG3;
    void Start()
    {
        LQ = GameObject.FindGameObjectWithTag("Player").GetComponent<LeafQuest>();
        MQ = GameObject.FindGameObjectWithTag("Player").GetComponent<MainQuest>();
        BG0.SetActive(false);
        BG1.SetActive(false);
        BG2.SetActive(false);
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
            if (MQ.quest & !LQ.questL)
            {
                dialog1 = true;
            }
            if (LQ.Find  & LQ.questL)
            {
                dialog2 = true;
            }
            if (MQ.AfterQuestL)
            {
                dialog3 = true;
            }
        }
        if (dialog0 & !MQ.quest)
        {
            StartDialog0();
        }
        if (dialog1 & !MQ.AfterQuestL)
        {
            StartDialog1();
        }
        if (dialog2 & LQ.Find)
        {
            StartDialog2();
        }
        if (MQ.AfterQuestL & dialog3)
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
            LQ.questL = true;
            Leaf.SetActive(false);
            Pos1.SetActive(true);
        }
        if (dialog1 == false)
        {
            BG1.SetActive(false);
        }
    }
    public void StartDialog2()
    {
        BG2.SetActive(true);
        if (Input.GetKeyDown(KeyCode.Q) & dialog2)
        {
            dialog2 = false;
            LQ.questL = false;
            LQ.Find = false;
            MQ.AfterQuestL = true;
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
            LQ.questL = true;
            Leaf.SetActive(false);
            Pos1.SetActive(true);
        }
        if (dialog3 == false)
        {
            BG3.SetActive(false);
        }
    }
}
