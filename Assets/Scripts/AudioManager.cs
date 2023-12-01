using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource Pop;
    public AudioSource Good;
    public AudioSource Bad;
    public void PlayPop() //Plays balloon popping sound.
    {Pop.Play();}
    public void PlayGood()
    {Good.Play(); Good.pitch += 0.1f;} //Plays victory sound. Makes it slightly more high-pitched every success.
    public void PlayBad() //Plays fail sound.
    {Bad.Play();}
}
