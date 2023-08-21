using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitNPC : MonoBehaviour
{    
    public bool dialog1;
    public bool dialog2;
    public bool dialog3;
    private MainQuest MP;
    public GameObject BG1;
    public GameObject BG2;
    public GameObject BG3;
    public GameObject CutScene;
    public GameObject MainCamera;
    public GameObject CSCamera;
    void Start()
    {
        MP = GameObject.FindGameObjectWithTag("Player").GetComponent<MainQuest>();
        BG1.SetActive(false);
        BG2.SetActive(false);
        BG3.SetActive(false);
        CutScene.SetActive(false);
    }
    void Update()
    {
        GameObject MissTagScanner = GameObject.FindGameObjectWithTag("Player");
        if (Input.GetKeyDown(KeyCode.E) & Vector3.Distance(transform.position, MissTagScanner.transform.position) < 2)
        {
            if (!MP.quest)
            {
                dialog1 = true;
            }            
            if (MP.quest)
            {
                dialog2 = true;
            }
            if (MP.PreEnd)
            {
                dialog3 = true;
            }
        }
        if (dialog1 & !MP.PreEnd)
        {
            StartDialog1();
        }
        if (dialog2 & MP.quest & !MP.PreEnd)
        {
            StartDialog2();
        }
        if (dialog3)
        {
            StartDialog3();
        }
    }
    public void StartDialog1()
    {
        BG1.SetActive(true);
        if (Input.GetKeyDown(KeyCode.Q) & dialog1)
        {
            dialog1 = false;
            MP.quest = true;
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
            MP.quest = false;
            MP.TheEnd = true;
            MP.PreEnd = false;
            MP.ED = true;
            MainCamera.SetActive(false);
            CSCamera.SetActive(true);
            CutScene.SetActive(true);
        }
        if (dialog3 == false)
        {
            BG3.SetActive(false);
        }
    }
}
