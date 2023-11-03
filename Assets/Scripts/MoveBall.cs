using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 0.03f;
    private string firstTag;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        Vector2 scale; //Scale of ball(initialize)
        int rnd = Random.Range(1, 100);

        switch (rnd % 6)
        {
            case 0:
            case 1:
            case 2:
                firstTag = "white";
                break;
            case 3:
            case 4:
                GetComponent<SpriteRenderer>().material.SetColor("_Color", Color.blue);
                firstTag = "blue";
                scale = new Vector2(1.5f, 1.5f);
                transform.localScale = scale;
                break;
            case 5:
                GetComponent<SpriteRenderer>().material.SetColor("_Color", Color.red);
                firstTag = "red";
                scale = new Vector2(2, 2);
                transform.localScale = scale;
                break;
        }
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
                rb.tag = firstTag;
            }
        }

        

        transform.position = ballPos;

    }
}
