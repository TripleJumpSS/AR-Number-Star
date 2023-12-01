using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberVOManager : MonoBehaviour
{
    public AudioSource[] SayTheNumber;
    public AudioSource[] DoTheNumber;
    public IEnumerator VOIntroduceNumber(int currentnumber)
    {
        currentnumber -= 1;
        SayTheNumber[currentnumber].Play();
        yield return new WaitForSeconds(8);
        DoTheNumber[currentnumber].Play();
    }
    
}
