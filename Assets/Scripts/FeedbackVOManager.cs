using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FeedbackVOManager : MonoBehaviour
{
    public List <AudioSource> PositiveFeedback;
    public AudioSource[] NegativeFeedback;
    public List <AudioSource> RemainingNegitiveFeedback;
    public AudioSource PreviousNegative;
    public void VOPraise()
    {
        AudioSource voiceline = PositiveFeedback[Random.Range(0, PositiveFeedback.Count)]; //Roll a new voiceline from the entries in the PositiveFeedback list.
        voiceline.Play();
        PositiveFeedback.Remove(voiceline);
    }

    public void VORepremand()
    {
        if(RemainingNegitiveFeedback.Count == 0)
        {
            RemainingNegitiveFeedback = NegativeFeedback.ToList();
            RemainingNegitiveFeedback.Remove(PreviousNegative);
        } 

        AudioSource voiceline = RemainingNegitiveFeedback[Random.Range(0, RemainingNegitiveFeedback.Count)]; //Roll a new voiceline from the entries in the RemainingNegativeFeedback list.
        voiceline.Play();
        PreviousNegative = voiceline;
        RemainingNegitiveFeedback.Remove(voiceline);
    }
}
