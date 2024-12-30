using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_script : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rb;// -------\
    [SerializeField] private float upwardforce;//------ this is to move the bird up 
    [SerializeField] private float boundery;// -----------/

   //----this is to move the bird forward


    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && rb.position.y < boundery)
        {
            flappy();
        }
        
    }

    void flappy()
    {
        rb.velocity = Vector2.zero;
        rb.AddForce(Vector2.up * upwardforce);
    }
     
}
