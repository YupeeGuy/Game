using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SQobject : MonoBehaviour
{
    private ChibiQuest CQ;    
    void Start()
    {
        CQ = GameObject.FindGameObjectWithTag("Player").GetComponent<ChibiQuest>();
    }
    void Update()
    {
        GameObject MissTagScanner = GameObject.FindGameObjectWithTag("Player");
        if (Input.GetKeyDown(KeyCode.E) & Vector3.Distance(transform.position, MissTagScanner.transform.position) < 1)
        {
            if (CQ.ObjectTag == gameObject.tag)
            {
                CQ.MissObjects = true;
                Destroy(gameObject);
            }
        }
    }
}
