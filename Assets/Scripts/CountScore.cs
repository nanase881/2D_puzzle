using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountScore : MonoBehaviour
{
    static private int score = 0;
    bool isCounted = false;

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("green") && !isCounted)
        {
            score++;
            isCounted = true;
            //Debug.Log(score);
        }
    }

    public static int ReturnScore()
    {
        return score;
    }
}
