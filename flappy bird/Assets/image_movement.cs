using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class image_movement : MonoBehaviour
{
    public Transform pointA, pointB;

    public float speed;

    Transform position;

    Vector2 location;

    private void Start()
    {
        location = pointA.position;
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, location , speed * Time.deltaTime);

        if(transform.position == pointA.position)
        {
            location = pointB.position;
        }
        if(transform.position == pointB.position)
        {
            location = pointA.position;
        }
    }
}
