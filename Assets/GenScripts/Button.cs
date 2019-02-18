using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public static int cameraNum = 0;
    Camera CameraOne;
    Camera CameraTwo;
    void Start()
    {
        CameraOne = GameObject.Find("CameraOne").GetComponent<Camera>();
        CameraTwo = GameObject.Find("CameraTwo").GetComponent<Camera>();
        CameraOne.enabled = true;
        CameraTwo.enabled = false;
    }

    public void Click()
    {
        if(cameraNum == 0)
        {
            CameraOne.enabled = true;
            CameraTwo.enabled = false;
            cameraNum = 1;
        }
        else
        {
            CameraTwo.enabled = true;
            CameraOne.enabled = false;
            cameraNum = 0;
        }
    }
}
