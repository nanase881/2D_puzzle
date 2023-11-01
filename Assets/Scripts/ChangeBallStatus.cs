using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBallStatus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("white") && gameObject.CompareTag("white"))
        {
            Destroy(collision.gameObject);
            gameObject.tag = "blue";
            GetComponent<SpriteRenderer>().material.SetColor("_Color", Color.blue);
            Vector2 scale = new Vector2(1.5f,  1.5f);
            transform.localScale = scale;
        }else if(collision.gameObject.CompareTag("blue") && gameObject.CompareTag("blue"))
        {
            Destroy(collision.gameObject);
            gameObject.tag = "red";
            GetComponent<SpriteRenderer>().material.SetColor("_Color", Color.red);
            Vector2 scale = new Vector2(2, 2);
            transform.localScale = scale;
        }
    }

}
