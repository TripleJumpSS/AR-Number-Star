using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FeedbackVOManager : MonoBehaviour
{
    public List <AudioSource> PositiveFeedback; //List of praising voice clips that decreases over use.
    public AudioSource[] NegativeFeedback; //Array of repremanding voice clips.
    public List <AudioSource> RemainingNegitiveFeedback; //List of repremanding voice clips that decreases over use. Resets when empty by pulling from NegativeFeedback.
    public AudioSource PreviousNegative; //The most recently used repremand. Stored to prevent repeat lines right after each other.
    public void VOPraise()
    {
        AudioSource voiceline = PositiveFeedback[Random.Range(0, PositiveFeedback.Count)]; //Roll a new voiceline from the entries in the PositiveFeedback list.
        voiceline.Play(); //Plays the voiceline.
        PositiveFeedback.Remove(voiceline); //Removes that voiceline from the list so it never plays again.
    }

    public void VORepremand()
    {
        if(RemainingNegitiveFeedback.Count == 0) //If there aren't anymore voicelines in RemainingNegitiveFeedback:
        {
            RemainingNegitiveFeedback = NegativeFeedback.ToList(); //pull from NegativeFeedback to refill the list.
            RemainingNegitiveFeedback.Remove(PreviousNegative); //remove the most recently used negative voiceline to avoid repetitivity.
        } 

        AudioSource voiceline = RemainingNegitiveFeedback[Random.Range(0, RemainingNegitiveFeedback.Count)]; //Roll a new voiceline from the entries in the RemainingNegativeFeedback list.
        voiceline.Play(); //Plays the voiceline.
        PreviousNegative = voiceline; //Sets the aformentioned voiceline as "PreviousNegative"
        RemainingNegitiveFeedback.Remove(voiceline); //Removes this voiceline from the list so it doesn't play again (until the list is refilled again).
    }
}
