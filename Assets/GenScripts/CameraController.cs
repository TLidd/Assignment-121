using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    float mouseX, mouseY;

    public GameObject target;
    Vector3 offset;
    Vector3 fix = new Vector3(0,0,3);

    void LateUpdate()
    {
        CameraControl();
    }

    void CameraControl()
    {
        mouseX += Input.GetAxis("Mouse X") * 3;
        mouseY += Input.GetAxis("Mouse Y") * 3;
        target.transform.rotation = Quaternion.Euler(0,mouseX,0);
    }
}