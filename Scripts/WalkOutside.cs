using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkOutside : MonoBehaviour
{
    public float isFast;
    public float movementSpeed;
    public float turningSpeed;
    public Transform Player;
    public WalkOutside abe;
    private Animator anim;
    private Transform MCam;
    void Awake()
    {
        abe = this;
    }
    void Start()
    {
        anim = GetComponent<Animator>();
        MCam = Camera.main.transform;
    }
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);
        float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        transform.Translate(0, 0, vertical);
        if ((vertical == 0) && (horizontal == 0))
        {
            anim.SetBool("IsWalk", false);
        }
        else
        {
            anim.SetBool("IsWalk", true);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetBool("IsFast", true);
            vertical = Input.GetAxis("Vertical") * isFast * Time.deltaTime;
            transform.Translate(0, 0, vertical);
        }
        else
        {
            anim.SetBool("IsFast", false);
        }
    }
}
