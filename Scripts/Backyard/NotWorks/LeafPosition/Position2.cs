using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position2 : MonoBehaviour
{
    private LeafQuest LQ;
    public GameObject pos2;
    public GameObject pos0;
    void Start()
    {
        LQ = GameObject.FindGameObjectWithTag("Player").GetComponent<LeafQuest>();
    }
    void Update()
    {
        GameObject MissTagScanner = GameObject.FindGameObjectWithTag("Player");
        if (Input.GetKeyDown(KeyCode.E) & Vector3.Distance(transform.position, MissTagScanner.transform.position) < 1)
        {
            LQ.Check2 = true;
            pos2.SetActive(false);
            pos0.SetActive(true);
        }
    }
}
