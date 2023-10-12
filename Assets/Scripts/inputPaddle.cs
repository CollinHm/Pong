using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class inputPaddle : MonoBehaviour
{
    public float speed = 24f;
    public string leftOrRight;
 
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (leftOrRight == "left")
        {
            if (Input.GetKey(KeyCode.W) && transform.position.y <= 3.9f)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
                Debug.Log("Yes W is pressed down.");
            }
            else if (Input.GetKey(KeyCode.S) && transform.position.y >= -3.9f)
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
                Debug.Log("Yes S is pressed down.");
            }
        }
        else if (leftOrRight == "right")
        {
            if (Input.GetKey(KeyCode.UpArrow) && transform.position.y <= 3.9f)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
                Debug.Log("Yes upArrow is pressed down.");
            }
            else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y >= -3.9f)
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
                Debug.Log("Yes downArrow is pressed down.");
            }
        }
      
    }

}
