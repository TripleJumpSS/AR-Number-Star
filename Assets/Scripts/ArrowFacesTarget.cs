using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowFacesTarget : MonoBehaviour
{
    public GameObject Balloon; //The object that the arrow turns to face.
    public GameObject ArrowModel; //The arrow model, this object's only child.
    public float strength; //How quickly the arrow turns.
    void Start()
    {
        ArrowModel = gameObject.transform.GetChild(0).gameObject; //Assigns ArrowModel to the Arrow Model.
        ArrowModel.GetComponent<MeshRenderer>().enabled = false; //Makes the Arrow invisible by default.
    }

    void Update()
    {        
            //Smoothly rotates arrow to face balloon using interpolation.
            Quaternion targetRotation = Quaternion.LookRotation (Balloon.transform.position - transform.position);
            float str = Mathf.Min (strength * Time.deltaTime, 1);
            transform.rotation = Quaternion.Lerp (transform.rotation, targetRotation, str);
    }

}
