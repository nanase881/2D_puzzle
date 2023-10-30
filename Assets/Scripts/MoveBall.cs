using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 0.03f;
    //Vector2 myGravity = new Vector2(0, 9.81f);

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector2 ballPos = transform.position;

        if (rb.CompareTag("operatable"))
        {
            if (Input.GetKey("left"))
            {
                ballPos.x -= speed;
            }
            else if (Input.GetKey("right"))
            {
                ballPos.x += speed;
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.gravityScale = 1;
                rb.tag = "white";
            }
        }

        

        transform.position = ballPos;

    }
}
