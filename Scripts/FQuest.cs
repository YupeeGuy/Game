using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FQuest : MonoBehaviour
{
    public string ObjectTag;
    public bool isObject;
    public bool quest;
    public GameObject CameraCut;
    public GameObject CameraCat;
    public GameObject CrashObject;
    public GameObject SQBG1;
    public GameObject CBG;
    public GameObject Continue;
    private WalkOutside WO;
    void Start()
    {
        WO = GameObject.FindGameObjectWithTag("Player").GetComponent<WalkOutside>();
        WO.abe.enabled = false;
        Continue.SetActive(false);
        SQBG1.SetActive(false);
        CBG.SetActive(false);
        CameraCut.SetActive(false);
        CrashObject.SetActive(false);
    }
    void Update()
    {
        if (CameraCat.activeInHierarchy)
        {
            quest = true;           
        }
        if (quest)
        {
            WO.abe.enabled = true;
            SQBG1.SetActive(true);
            if (isObject)
            {
                SQBG1.SetActive(false);
                CBG.SetActive(true);
                CameraCat.SetActive(false);
                CameraCut.SetActive(true);
                CrashObject.SetActive(true);
                Continue.SetActive(true);
                quest = false;
            }
        }
        if (!quest & isObject)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Backyard");
            }
        }
    }
}
