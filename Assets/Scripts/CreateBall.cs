using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBall : MonoBehaviour
{
    public GameObject ballPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Invoke("InstantiateBall", 1.0f);
            
        }
    }

    void InstantiateBall()
    {
        Vector2 pos = new Vector2(0.02f, 3.52f);
        Instantiate(ballPrefab, pos, Quaternion.identity);
    }
  
}
