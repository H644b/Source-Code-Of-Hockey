using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RhinoScore : MonoBehaviour
{
   public Text label;
   static int score=0; 

    
    

    void OnTriggerEnter2D(Collider2D collision)
    {
       score = score+1;  
       label.text = "BearScore: " +score;
      
       
    }


}
