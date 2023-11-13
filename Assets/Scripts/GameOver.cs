using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public bool falled = false;

    private void Start()
    {

    }

    private void Update()
    {
        if(falled == false)
        {
            CancelInvoke("Result");
        }
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        falled = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        falled = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Spawn"))
        {
            if (falled == true)
            {
                Invoke("Result",  5f);
            }
        }
    }

    void Result()
    {
        //Debug.Log("Game over");
        SceneManager.LoadScene("Result");
    }

}
