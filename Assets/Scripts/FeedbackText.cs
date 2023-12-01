using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FeedbackText : MonoBehaviour
{
    public float Timer; //Decreases when text is displayed. Clears text when zero.
    public bool DisplayFeedback; //Is only true when text is to be displayed.
    public int LanuageValue; //Checks the current language. 0 is English, 2 is French, 3 is Spanish, 4 is Italian. 
    public GameObject GameManager; //Where we pull the current language from.
    
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
        LanuageValue = GameManager.GetComponent<GameManager>().LanuageValue; //We pull the current language from GameManager.
        DisplayFeedback = true; //Setting this to true lets the timer run.
        Timer = 2; //Sets the timer to 2 seconds, after which the text will be blank.

        switch (LanuageValue)
        {
            case 0: gameObject.GetComponent<TMP_Text>().text = "Good Job"; break; //Sets text to display "Good Job!" in English.
            case 1: gameObject.GetComponent<TMP_Text>().text = "Bon Travail"; break; //Sets text to display ""Bon Travail" in French.
            case 2: gameObject.GetComponent<TMP_Text>().text = "Buen Trabajo"; break; //Sets text to display "Buen Trabajo" in Spanish.
            case 3: gameObject.GetComponent<TMP_Text>().text = "Ottimo Lavoro"; break; //Sets text to display "Ottimo Lavoro" in Italian.
            default: print("invalid langvalue in feedback text"); break;
        }
    }

    public void TryAgain() //Displays "Try Again..." for 2 seconds, then clears text.
    {
        LanuageValue = GameManager.GetComponent<GameManager>().LanuageValue; //We pull the current language from GameManager.
        DisplayFeedback = true; //Setting this to true lets the timer run.
        Timer = 2; //Sets the timer to 2 seconds, after which the text will be blank.

        switch (LanuageValue)
        {
            case 0: gameObject.GetComponent<TMP_Text>().text = "Try Again"; break; //Sets text to display "Good Job!" in English.
            case 1: gameObject.GetComponent<TMP_Text>().text = "Réessayer"; break; //Sets text to display "Réessayer" in French.
            case 2: gameObject.GetComponent<TMP_Text>().text = "Inténtalo De Nuevo"; break; //Sets text to display "Inténtalo De Nuevo" in Spanish.
            case 3: gameObject.GetComponent<TMP_Text>().text = "Riprova"; break; //Sets text to display "Riprova" in Italian.
            default: print("invalid langvalue in feedback text"); break;
        }
    }
}
