using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counter : MonoBehaviour
{
    Text count_text;
    void Start()
    {
        count_text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

        if (count_text.text != score.coins.ToString())
        {
            count_text.text = score.coins.ToString();
        }
        if (count_text.text != score.coins.ToString())
        {
            count_text.text = score.coins.ToString();
        }
    }
}
