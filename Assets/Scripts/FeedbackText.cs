using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FeedbackText : MonoBehaviour
{
    public float Timer; //Decreases when text is displayed. Clears text when zero.
    public bool DisplayFeedback; //Is only true when text is to be displayed.
    
    void Start() //Clears text to start.
    {
        gameObject.GetComponent<TMP_Text>().text = ""; //Makes the text blank.
    }

    void Update()
    {
        if(Timer > 0 && DisplayFeedback == true) //Timer decreases when text is displayed.
        {Timer -= 1 * Time.deltaTime;}

        else if(Timer <= 0 && DisplayFeedback == true) //Clears text when Timer reaches zero.
        {
            gameObject.GetComponent<TMP_Text>().text = ""; //Makes the text blank.
            DisplayFeedback = false; //Setting this to false stops the timer running.
        }

    }

    //The following two methods are triggered by the GameManager script when you tap a button.
    public void GoodJob() //Displays "Good Job!" for 2 seconds, then clears text.
    {
        DisplayFeedback = true; //Setting this to true lets the timer run.
        Timer = 2; //Sets the timer to 2 seconds, after which the text will be blank.
        gameObject.GetComponent<TMP_Text>().text = "Good Job!"; //Sets text to display "Good Job!"
    }

    public void TryAgain() //Displays "Try Again..." for 2 seconds, then clears text.
    {
        DisplayFeedback = true; //Setting this to true lets the timer run.
        Timer = 2; //Sets the timer to 2 seconds, after which the text will be blank.
        gameObject.GetComponent<TMP_Text>().text = "Try Again..."; //Sets text to display "Try Again..."
    }
}
