using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBalloonColour : MonoBehaviour
{
    public Material Red;
    public Material Green;
    public Material Blue;
    public Material Yellow;
    public float ColourNumber; //Keeps track of which colour the balloon should be.
    void Start()
    {ColourNumber = 1;} //The balloon is red to start.
    public void ChangeBalloonHue()
    {
        ColourNumber += 1; //After the player gets an answer right, the colour changes to the next one.
        if(ColourNumber > 4) //Once the colours have all been cycled through, return to red and repeat.
        {ColourNumber = 1;}

        switch (ColourNumber)
        {
            case 1: gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().material = Red; break; //Round 1, 5 & 9: Balloon is Red.
            case 2: gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().material = Green; break; //Round 2, 6 & 10: Balloon is Green.
            case 3: gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().material = Blue; break; //Round 3 & 7: Balloon is Blue.
            case 4: gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().material = Yellow; break; //Round 4 & 8: Balloon is Yellow.
            default: print("BALLOON HUE IS BROKEN SOMEHOW! INCONCEIVABLE!!!"); break;
        }
    }
}
