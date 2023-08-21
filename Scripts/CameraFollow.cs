using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform CameraTarget;
    public Transform PlayerModel;
    public Transform Camera;
    public float minAngle;
    public float maxAngle;
    public float mouseSens;
    public bool stickCamera;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
        float aimX = Input.GetAxis("Mouse X");
        float aimY = Input.GetAxis("Mouse Y");
        CameraTarget.rotation *= Quaternion.AngleAxis(aimX * mouseSens, Vector3.up);
        CameraTarget.rotation *= Quaternion.AngleAxis(-aimY * mouseSens, Vector3.right);
        var angleX = CameraTarget.localEulerAngles.x;
        if (angleX > 180 && angleX < maxAngle)
        {
            angleX = maxAngle;
        }
        else if (angleX < 180 && angleX > minAngle)
        {
            angleX = minAngle;
        }
        CameraTarget.localEulerAngles = new Vector3(angleX, CameraTarget.localEulerAngles.y, 0);
        if (stickCamera)
        {
            PlayerModel.rotation = Quaternion.Euler(0, CameraTarget.rotation.eulerAngles.y, 0);
        }
    }
}
