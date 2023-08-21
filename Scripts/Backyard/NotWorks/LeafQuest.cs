using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafQuest : MonoBehaviour
{
    public bool Find;
    public bool questL;
    public GameObject SQBG1;
    public GameObject CBG;
    public bool Check0 = false;
    public bool Check1 = false;
    public bool Check2 = false;
    public void Start()
    {
        SQBG1.SetActive(false);
        CBG.SetActive(false);
    }
    public void Update()
    {
        if (Check0 & Check1 & Check2)
        {
            Find = true;
        }
        if (questL)
        {
            CBG.SetActive(false);
            SQBG1.SetActive(true);
        }
        if (Find & !questL)
        {
            SQBG1.SetActive(false);
            CBG.SetActive(true);
            Check0 = false;
            Check1 = false;
            Check2 = false;
            Find = false;
        }
    }
}
