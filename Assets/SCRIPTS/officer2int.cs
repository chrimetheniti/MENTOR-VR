using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class officer2int : MonoBehaviour
{
    public GameObject officer2;
   

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.name == ("BodyCollider")
)        {

            Debug.Log("onarea");

            officer2.GetComponent<Animator>().CrossFade("Idle", 0.1f);
            officer2.GetComponent<AudioSource>().Play();
        }
    }
  }
