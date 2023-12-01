using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PopManager : MonoBehaviour
{
    public GameObject fireworks; //Particle effect that plays when the balloon pops.
    public GameObject Arrow; //Briefly disables the arrow to not visually obstruct the fireworks.
    public Transform Balloon; //We get the balloon location to figure out where the fireworks should be located.
    
    public IEnumerator Pop() //Triggered by GameManager when player ChoseRight.
    {
        GameObject FireworkInstance = Instantiate(fireworks); //Spawn a firework prefab into the scene.
        FireworkInstance.transform.position = Balloon.position; //Sets the firework's location to be where the balloon is.
        Arrow.SetActive(false); //Disable the arrow so we can see the fireworks without a giant arrow in the way.
        yield return new WaitForSeconds(0.5f); //Wait half a second.
        Arrow.SetActive(true); //Enable the arrow again now that the fireworks have auto-despawned.
    }
}
