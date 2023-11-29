using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class ShuffleButtonPositions : MonoBehaviour
{
    public GameObject[] Buttons; //An array of every tappable button.
    public Vector3[] ButtonLocations; //An array of all possible locations buttons can be at.
    public List<Vector3> TempButtonLocations; //A temporary copy of ButtonLocations generated every shuffle.
    
    void Start()
    {Shuffle();} //Calls Shuffle when game starts.
    public void Shuffle() //Randomly shuffles the button positions.
    {
        TempButtonLocations = ButtonLocations.ToList(); //Copies the ButtonLocations data to the TempButtonLocations list.

        foreach (GameObject button in Buttons) //The following is done to every button in the array:
        {
            var RandomPos = TempButtonLocations[Random.Range(0, TempButtonLocations.Count)]; //1) Randomly pick a TempButtonLocation.
            button.transform.localPosition = RandomPos; //2) The button's position is set to the randomly chosen TempButtonLocation.
            TempButtonLocations.Remove(RandomPos); // 3)The randomly chosen location is removed from TempButtonLocation to avoid repeats.
                                                //4) Rinse and repeat until every button has a location.
        }
        
    }
}
