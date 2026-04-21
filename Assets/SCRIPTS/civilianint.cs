using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class civilianint : MonoBehaviour
{
    public GameObject civilian;
   
    

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.name== "BodyCollider")
        {
          
            civilian.GetComponent<Animator>().CrossFade("Idle", 0.1f);
           civilian.GetComponent<AudioSource>().Play();

            Debug.Log("onarea");

        }
    }
}
