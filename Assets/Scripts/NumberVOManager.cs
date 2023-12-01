using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberVOManager : MonoBehaviour
{
    public AudioSource[] SayTheNumber; //A list of "This is the number X. Can you say X?" lines in various languages.
    public AudioSource[] DoTheNumber; //A list of "Press the X button." lines in various languages.
    public IEnumerator VOIntroduceNumber(int currentnumber)
    {
        currentnumber -= 1; //We use the CurrentNumber from the GameManager to figure out which line to say (we subtract one to circomvent a bug)

        SayTheNumber[currentnumber].Play(); //Play the "This is the number X. Can you say X?" voice clip associated with the current CurrentNumber.

        yield return new WaitForSeconds(8); //Wait 8 seconds to let the 1st voiceclip play AND give the player time to say the number out loud.
        
        DoTheNumber[currentnumber].Play(); //Play the "Press the X button." voice clip associated with the current CurrentNumber.
    }
    
}
