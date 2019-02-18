using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Color newcolor = new Color(0,0,1);
        GetComponent<Renderer>().material.color = newcolor;
    }
}
