using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;

public class ball : MonoBehaviour
{
    public float Xposition = 0f;
    public float Yposition = 0f;
    public float xSpeed = 1f;
    public float ySpeed = 1f;
    public TMP_Text scoreField;
    private int leftScore = 0;
    private int rightScore = 0;
    public int topScore = 10;


   private void resetBall(string leftOrRight)
    {
        Xposition = 0f;
        Yposition = 0f;
        scoreField.text = leftScore + " - " + rightScore;
        if (leftOrRight == "left") 
        {
            xSpeed = -3f;
            ySpeed =  3f;
        }
        else if (leftOrRight == "right")
        {
            xSpeed = 3f;
            ySpeed = -3f;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

       // transform.position = new Vector3(Xposition, Yposition, 0);
       
        xSpeed = 7f;
        ySpeed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        Xposition += xSpeed * Time.deltaTime;
        Yposition += ySpeed * Time.deltaTime;
        transform.position = new Vector3(Xposition, Yposition, 0);
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("horizontalWall"))
        {
            ySpeed = ySpeed * -1f;
        }
       else if (collision.gameObject.CompareTag("leftWall"))
        {
            
            rightScore++;
            resetBall("left");
            
        }
        else if (collision.gameObject.CompareTag("rightWall"))
        {
            
            leftScore++;
            resetBall("right");    
            
        }
        else if (collision.gameObject.CompareTag("player"))
        {
            xSpeed = xSpeed * -1.1f;
        }
      
       
    }



}

