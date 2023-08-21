using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    private FQuest FQ;
    void Start()
    {
        FQ = GameObject.FindGameObjectWithTag("Player").GetComponent<FQuest>();
    }
    void Update()
    {
        GameObject MissTagScanner = GameObject.FindGameObjectWithTag("Player");
        if (Input.GetKeyDown(KeyCode.E) & Vector3.Distance(transform.position, MissTagScanner.transform.position) < 5)
        {
            if (FQ.ObjectTag == gameObject.tag)
            {
                FQ.isObject = true;
                Destroy(gameObject);
            }
        }
    }
}
