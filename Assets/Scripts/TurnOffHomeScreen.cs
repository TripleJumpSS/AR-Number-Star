using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffHomeScreen : MonoBehaviour
{
    public GameObject HomeScreen;
    void Start()
    {
        Time.timeScale = 0; //Freezes the game state to start.
    }

    // Update is called once per frame
    public void StartGame()
    {
        Time.timeScale = 1; //Allow the game to run at normal speed once the player presses play.
        HomeScreen.SetActive(false); //Disables the main menu object so the player can play.
    }
}
