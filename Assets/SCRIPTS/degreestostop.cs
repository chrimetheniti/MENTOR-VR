using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class degreestostop : MonoBehaviour
{
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "degrees")
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "degrees")
        { this.gameObject.GetComponent<Renderer>().material.color = Color.red; }
    }



}
