using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exittutorial : MonoBehaviour
{ public GameObject tutorialscene;
    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.name == "BodyCollider")
        {
            Destroy(tutorialscene);
        }
    }
}
