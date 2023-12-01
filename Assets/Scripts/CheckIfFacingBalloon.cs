using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfFacingBalloon : MonoBehaviour
{
    public GameObject Arrow; //The model of the arrow that rotates towards the balloon.
    public GameObject GameManager; //Enables voice-over and buttons after the balloon is first seen.
    public bool LookingForNextBalloon; //True after the player gets an answer right, but before they see the next balloon.

    void OnTriggerEnter(Collider c)
    {
        if(c.gameObject.tag == "Cube") //Makes arrow invisible when facing the Balloon.
        {FacingBalloon();}
    }
    void OnTriggerExit(Collider c)
    {
        if(c.gameObject.tag == "Cube") //Makes arrow visible when not facing the Balloon.
        {NotFacingBalloon();}
    }

    public void FacingBalloon()
    {
        Arrow.GetComponent<MeshRenderer>().enabled = false; //Makes arrow invisible when facing the Balloon.

        if(LookingForNextBalloon) //These only apply after the player gets an answer right, but before they see the next balloon:
        {
            StartCoroutine(GameManager.GetComponent<GameManager>().BalloonSpotted()); //Starts voice-over, eventually enables the buttons after a few seconds.
            LookingForNextBalloon = false; //Disables boolean to stop this function from happening again this round.
        }

    }

    public void NotFacingBalloon()
    {
        Arrow.GetComponent<MeshRenderer>().enabled = true; //Makes arrow visible when not facing the Balloon.
    }
}
