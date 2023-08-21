using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndDialog : MonoBehaviour
{
    public GameObject Rabbit;
    public GameObject EDText;
    public GameObject MissBG;
    public GameObject White;

    private MainQuest MQ;

    public Animator EndAnim;

    // Start is called before the first frame update
    void Start()
    {
        MQ = GameObject.FindGameObjectWithTag("Player").GetComponent<MainQuest>();
        EDText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (MQ.TheEnd & MQ.PreEnd)
        {            
            StartEndDialog();
        }       
    }

    public void StartEndDialog()
    {
        MissBG.SetActive(false);
        EDText.SetActive(true);

        if (Input.GetKeyDown(KeyCode.Q) & MQ.ED)
        {
            MQ.ED = false;
            EndAnim.SetBool("IsTheEnd", true);
            if (MQ.TheEnd)
            {
                Rabbit.SetActive(false);
            }
        }

        if (!MQ.ED)
        {
            EDText.SetActive(false);
            White.SetActive(true);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
