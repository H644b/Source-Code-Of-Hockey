using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKB : MonoBehaviour
{

    public float speed;
static int score=0;

    void Update()
    {
 
        if (Input.GetKey("up"))
        {
            if (transform.position.y < 4.41f)
                  transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

        if (Input.GetKey("down"))
        {
            if (transform.position.y > -4.51f) 
                 transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
       score = score +1;
       print(score); 
      
    }

}
