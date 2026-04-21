using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class compassint : MonoBehaviour
{
    public GameObject compasstext;
    public GameObject compassrose;
    public GameObject pointer;
    public GameObject wheeltext;
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
            compasstext.SetActive(true);
            compassrose.SetActive(true);
            pointer.SetActive(true);
            wheeltext.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "BodyCollider")
        {
         compasstext.SetActive(false);

        }
    }
}
