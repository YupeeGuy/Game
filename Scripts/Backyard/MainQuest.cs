using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainQuest : MonoBehaviour
{
    public bool quest;
    public bool TheEnd;
    public bool PreEnd;
    public bool ED;
    public GameObject MBG;
    public GameObject CBG;
    public GameObject BG0;
    public bool AfterQuestL;
    public bool AfterQuestM;
    public bool AfterQuestCC;
    public void Start()
    {
        BG0.SetActive(true);
        MBG.SetActive(false);
        CBG.SetActive(false);
    }
    public void Update()
    {
        if (AfterQuestCC & AfterQuestM & AfterQuestL)
        {
            PreEnd = true;
        }
        if (quest)
        {
            MBG.SetActive(true);
            BG0.SetActive(false);
            if (PreEnd)
            {
                CBG.SetActive(true);
                MBG.SetActive(false);
            }
        }
    }
}
