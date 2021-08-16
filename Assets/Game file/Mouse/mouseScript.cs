using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseScript : MonoBehaviour
{
    public Animator anim;

    public int speed;
    public int rotate;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        


        playermovement();
    }

    void playermovement()
    {
        float X = Time.deltaTime * rotate;
        float Z = Time.deltaTime * speed;
        transform.Translate(0, 0, Z);
        transform.Rotate(0, X, 0);
    }
}
