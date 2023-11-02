using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pongBot : MonoBehaviour
{
    //Variables

    //Vertical Speed
    public float ySpeed = 3f;
    //Vertical position
    public float yPosition = 0f;

    // Update is called once per frame
    void Update()
    {
        //vertical movement of right paddle
        //updates the yPosition with ySpeed multiplied with Time.deltaTime for real time movement
        yPosition = yPosition + ySpeed * Time.deltaTime;
        //X position is handled with the current X position
        transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);
        //if the yPosition is equal or bigger than 3.9f, it does something
        if (yPosition >= 3.9f)
        {
            //ySpeed multiplies with -1 so it goes in a different direction
            ySpeed = ySpeed * -1f;
        }
        //if yPosition is equal or lower than -3.9f, it does something
        else if (yPosition <= -3.9f)
        {
            //ySpeed multiplies with -1 so it goes in a different direction0
            ySpeed = ySpeed * -1f;

        }
        //transform.position = new Vector3(transform.position.x, ball.transform.position.y/ySpeed, transform.position.z);
    }
}
