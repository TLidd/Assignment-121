using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("IS Not");
        if(Pickups.Score == 8){
            //Debug.Log("IS DOWN");
            Pickups.Score = 0;
            SceneManager.LoadScene("MainMenu");
            SceneManager.UnloadScene("Scene1");
        }
    }
}
