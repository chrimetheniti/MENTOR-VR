using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelint : MonoBehaviour
{
    public GameObject officer2;


    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.name == "BodyCollider")
        {

            officer2.SetActive(true);
        }
    }
}
