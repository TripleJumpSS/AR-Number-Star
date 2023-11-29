using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Correct Number")]
    public int CorrectNumber; //The number displayed on NumberCubeText. Randomised when RollNewNumber is called.
    public TMP_Text NumberCubeText; //The textbox on the cube that displays the correct number.
    
    [Header("Score")]
    public int Score; //Goes up every time the player chooses right.
    public TMP_Text ScoreText; //Displays Score.
    public GameObject FeedbackText; //Displays "Good Job!" when correct, "Try Again..." when wrong. [See: FeedbackText.cs]

    [Header("Interactive UI")]
    public TMP_Text RightNumberText; //The button that displays the correct number.
    public TMP_Text WrongNumberText1; //The button that displays the wrong number.
    public TMP_Text WrongNumberText2; //Another button that displays the wrong number.
    public GameObject UIBottomBar; //Contains the button shuffling script;
    void Start()
    {RollNewNumber();} //Randomises CorrectNumber immediately.

    void RollNewNumber() //Randomises CorrectNumber.
    {
        int newNumber =  Random.Range(1,8); //Roll a new number

        while (newNumber == CorrectNumber) //If the number is the same as last time, add 1. This prevents duplicates.
        {newNumber += 1;}

        CorrectNumber = newNumber; //Sets number now we know for sure it isn't a duplicate.

        NumberCubeText.text = CorrectNumber.ToString(); //Sets the cube's textbox to the new CorrectNumber.

        RightNumberText.text = CorrectNumber.ToString(); //Sets the right button's textbox to the new CorrectNumber.
        WrongNumberText1.text = (CorrectNumber + 1).ToString(); //Sets the wrong button's textbox to a different number.
        WrongNumberText2.text = (CorrectNumber - 1).ToString(); //Sets the wrong button's textbox to a different number.

        UIBottomBar.GetComponent<ShuffleButtonPositions>().Shuffle(); //Shuffles the button's positions. [See: ShuffleButtonPositions.cs]
    }


    //The following two methods are triggered when you tap a button.
    public void ChoseRight() //Triggered when correct number is tapped.
    {
        Score += 1; //Increases Score counter by 1.
        ScoreText.text = "SCORE: " + Score.ToString(); //Displays score count in UI textbox. 
        FeedbackText.GetComponent<FeedbackText>().GoodJob(); //Celebrates the player's success with a "Good Job!" [See: FeedbackText.cs]
        RollNewNumber(); //Randomises CorrectNumber for the next round.
    }
    public void ChoseWrong() //Triggered when the wrong number is tapped.
    {
        FeedbackText.GetComponent<FeedbackText>().TryAgain(); //Aknowledges the player's failure with a "Try Again..." [See: FeedbackText.cs]
    }
}
