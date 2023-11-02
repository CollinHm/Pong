using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;

public class ball : MonoBehaviour
{
   /// <summary>
   /// Settings for the ball
   /// -Move n x- and y direction
   /// -change course when it collides with a wall or paddle
   /// -Scoring when ball hits left- or right wall
   /// -showing score in a text field
   /// -when ball hits a paddle it speeds up
   /// </summary>
   

//Variables
//Horizontal and Vertical positioning
    public float Xposition = 0f;
    public float Yposition = 0f;
    //Horizontal and Vertical speed
    public float xSpeed = 1f;
    public float ySpeed = 1f;
    private float baseLineSpeed;
    //Reference to text object (has to be linked in Unity)
    public TMP_Text scoreField;
    //Keeping the scores at 0
    private int leftScore = 0;
    private int rightScore = 0;
    //If the top score is met, it stops the game
    public int topScore = 20;

    //Function for resetting the ball to start position and adds score to either side
   private void resetBall(string leftOrRight)
    {
        //Starting position for X and Y
        Xposition = 0f;
        Yposition = 0f;
        //Displays score in text field
        scoreField.text = leftScore + " - " + rightScore;
        //checks argument from the function if either left or right is typed in
        if (leftOrRight == "left") 
        {
            //Ball goes right and down
            xSpeed = -baseLineSpeed;
            ySpeed = baseLineSpeed;
        }
        else if (leftOrRight == "right")
        {
            //Ball goes left and up
            xSpeed = -baseLineSpeed;
            ySpeed = baseLineSpeed;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //Set baseline speed
        baseLineSpeed = xSpeed;

        //Set starting x and y position for the ball
       transform.position = new Vector3(Xposition, Yposition, 0);
       
        xSpeed = 20f;
        ySpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        //Updates the X and Y position with xSpeed and ySpeed multiplied with Time.deltaTime
        //So the ball is moving not on framerate but actual time so speed is the same for everyone
        Xposition += xSpeed * Time.deltaTime;
        Yposition += ySpeed * Time.deltaTime;
        //Updates the position with new values
        transform.position = new Vector3(Xposition, Yposition, 0);
       
        //checks if the left or right side has reached the top score
        //when the top score is met it resets the ball
        //shows in text field which side has won the game
        if(leftScore >= topScore)
        {
            scoreField.text = "Left Player has won!";
            xSpeed = 0;
            ySpeed = 0;
            Xposition = 0f;
            Yposition = 0f;
        }
        else if (rightScore >= topScore)
        {
            scoreField.text = "Right Player has won!";
            xSpeed = 0;
            ySpeed = 0;
            Xposition = 0f;
            Yposition = 0f;
        }
    }

    //If it hits something(gameobject) with a collider(2D) that is set to trigger, it does something
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //when the gameobject has a tag that is called "horizontalWall"
        //and it has a collider on it set to trigger, it will bounce it back
        if (collision.gameObject.CompareTag("horizontalWall"))
        {
            //flips direction vertical from up to down or vice versa
            ySpeed = ySpeed * -1f;
        }
       else if (collision.gameObject.CompareTag("leftWall"))
        {
            //adds a point to the right score and resets the ball(triggers the reset function with left argument)
            rightScore++;
            resetBall("left");
            
        }
        else if (collision.gameObject.CompareTag("rightWall"))
        {
            //adds a point to the left score and resets the ball(triggers the reset function with right argument)
            leftScore++;
            resetBall("right");    
            
        }
        else if (collision.gameObject.CompareTag("player"))
        {
            //when it hits the player operated pannel, it changes the direction of the ball
            xSpeed = xSpeed * -1f;
        }
      
       
    }



}

