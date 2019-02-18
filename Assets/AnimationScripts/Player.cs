using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float speed = 6;


    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)){
               anim.SetBool("Moving", true);
        }
        if(Input.GetKeyUp(KeyCode.W)){
            anim.SetBool("Moving", false);
        }
        transform.Translate(((Input.GetAxis("Horizontal") * speed) * Time.deltaTime),
        0, (Input.GetAxis("Vertical") * speed) * Time.deltaTime);
    }
}
