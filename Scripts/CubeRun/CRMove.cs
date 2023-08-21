using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CRMove : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce;
    public float SideForce;
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, -ForwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }        
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < 45f)
        {
            FindObjectOfType<CRGameManager>().EndGame();
        }
    }
}
