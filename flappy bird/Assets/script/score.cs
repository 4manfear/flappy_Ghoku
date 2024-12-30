using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public static int coins = 0;

    private void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D cs2d)
    {

        if (cs2d.CompareTag("bird"))
        {
            // +1
            coins++;
            Debug.Log("coin is collectied");
            Destroy(gameObject);


        }
    }
}
