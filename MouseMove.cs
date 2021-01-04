using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MouseMove : MonoBehaviour
{

    public float speed;


    void Update()
    {
       
         if(Input.GetAxis("Mouse Y")>0)
	  if (transform.position.y < 4.41f) 
             transform.Translate(Vector2.up * speed * Time.deltaTime);
   
          if(Input.GetAxis("Mouse Y")<0)
             if (transform.position.y > -4.51f)
               transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    

}
