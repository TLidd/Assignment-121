using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textScript : MonoBehaviour
{
    Text myText;
    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponent<Text>();
    }
    //Pickups score = myText.GetComponent<Pickups>().getScore();
    // Update is called once per frame
    void Update()
    {
        myText.text = "Score: " + Pickups.Score;
    }
}
