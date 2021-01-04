using UnityEngine;
using System.Collections;

public class KeyHandler : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("down"))
        {
            print("down");
        }
       
           if (Input.GetKeyDown("up"))
        {
            print("up");
        }
    }
}
