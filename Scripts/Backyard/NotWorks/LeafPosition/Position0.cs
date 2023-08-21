using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position0 : MonoBehaviour
{
    private LeafQuest LQ;
    public GameObject Leaf;
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
            LQ.Check0 = true;
            pos0.SetActive(false);
            Leaf.SetActive(true);
        }
    }
}
