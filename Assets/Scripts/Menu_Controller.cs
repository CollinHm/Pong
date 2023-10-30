using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_Controller : MonoBehaviour
{


    public Button Singleplayer_Button;
    public Button Multiplayer_Button;
    public Button SPEED_Button;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void Singleplayer_pongOnePlayer()
    {

        SceneManager.LoadScene("pongOnePlayer");
    }

    public void Multiplayer_pongTwoPlayer()
    {
        SceneManager.LoadScene("pongTwoPlayer");
    }

    public void SPEED_SPEED()
    {
        SceneManager.LoadScene("SPEED");
    }



}
