using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boyScript : MonoBehaviour
{
    public Animator anim;

    public float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("jump", true);
            transform.Translate(0, 1, speed*2);

        }
        else
            anim.SetBool("jump", false);


        transform.Translate(0, 0, speed);
    }
}
