using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBall : MonoBehaviour
{
    public GameObject ballPrefab;
    private bool ballExist = true;


    void InstantiateBall()
    {
        if(ballExist == false)
        {
            Vector2 pos = new Vector2(0.02f,  3.86f);
            Instantiate(ballPrefab, pos, Quaternion.identity);
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        ballExist = false;
        Invoke("InstantiateBall",  0.5f);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        ballExist = true;
    }

}
