using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position1 : MonoBehaviour
{
    private LeafQuest LQ;
    public GameObject pos1;
    public GameObject pos2;
    void Start()
    {       
        LQ = GameObject.FindGameObjectWithTag("Player").GetComponent<LeafQuest>();
    }
    void Update()
    {
        GameObject MissTagScanner = GameObject.FindGameObjectWithTag("Player");
        if (Input.GetKeyDown(KeyCode.E) & Vector3.Distance(transform.position, MissTagScanner.transform.position) < 1)
        {
            LQ.Check1 = true;
            pos1.SetActive(false);
            pos2.SetActive(true);

        }
    }
}
