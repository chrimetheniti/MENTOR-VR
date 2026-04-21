using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class officerint : MonoBehaviour
{
    public GameObject officer1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.name == "BodyCollider")
        {
            officer1.GetComponent<Animator>().CrossFade("Idle", 0.1f);
            officer1.GetComponent<AudioSource>().Play();
            Debug.Log("onarea");
        }
    }
}