using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    Rigidbody2D rb;
    public bool falled = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //if (!gameObject.CompareTag("operatable"))
        //{
        //    if (rb.velocity.x < 0.1f && rb.velocity.y < 0.1f)
        //    {
                
        //    }
        //}
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        falled = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Spawn"))
        {
            if (falled == true)
            {
                Invoke("Result", 5f);
                 // 途中でfalledがfalseになったら、Involke処理をキャンセル出来るようにする
            }
        }
    }

    void Result()
    {
        Debug.Log("Game over");
    }

}
