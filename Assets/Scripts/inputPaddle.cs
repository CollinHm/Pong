using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class inputPaddle : MonoBehaviour
{
    //variables
    //handling speed of the paddle
    public float speed = 24f;
    //checks wether it's the right or left paddle
    //has to be changed within Unity
    public string leftOrRight;
 
    /// <summary>
    /// function that handles movement and has arguments for up and down keycode
    /// </summary>
    /// <param name="up">key that is handling up input</param>
    /// <param name="down">key that is handling down input</param>
   void setKeyAndMovement(KeyCode up, KeyCode down)
    {
        //When up key is pressed, held down and current yPosition is equal to/smaller than 3.9f
        if (Input.GetKey(up) && transform.position.y <= 3.9f)
        {
            //Translate works with a new Vector3 and it changes with a new Vector3.up multiplied with speed and Time.deltaTime
          transform.Translate(Vector3.up * speed * Time.deltaTime);    
        }
        else if (Input.GetKey(down) && transform.position.y >= -3.9f)
        {
            //Translate works with a new Vector3 and it changes with a new Vector3.down multiplied with speed and Time.deltaTime
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }
 

    // Update is called once per frame
    void Update()
    {
       if (leftOrRight == "left")
        {
            setKeyAndMovement(KeyCode.W, KeyCode.S);
        }
       else if (leftOrRight == "right")
        {
            setKeyAndMovement(KeyCode.UpArrow, KeyCode.DownArrow);
        }
      
    }

}
