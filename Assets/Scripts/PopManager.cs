using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PopManager : MonoBehaviour
{
    public GameObject fireworks;
    public GameObject Arrow;
    public Transform Balloon;
    
    public IEnumerator Pop()
    {
        GameObject FireworkInstance = Instantiate(fireworks);
        FireworkInstance.transform.position = Balloon.position;
        Arrow.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        Arrow.SetActive(true);
    }
}
