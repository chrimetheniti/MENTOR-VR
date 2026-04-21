using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;


public class pencilint : MonoBehaviour
{
    public GameObject point1;
    public GameObject point2;
    public GameObject point3;
    public bool check1;
    public bool check2;
    public GameObject compassotext;
    public GameObject rosetext2;
    public GameObject rosetext1;
    public GameObject penciltext;
    public GameObject mapwithoutcourse;
    public GameObject mapwithcourse;
    public GameObject courseline;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (check1 == true && check2 == true)
        {
            mapwithcourse.SetActive(true);
           
            mapwithoutcourse.SetActive(false);

            compassotext.SetActive(true);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name== "point1")
        {
            check1 = true;
            Destroy(point1);
            Debug.Log("point1reached");
        }
        if (other.gameObject.name == "point2")
        {
            check2 = true;
            Destroy (point2);
            Debug.Log("point2reached");
        }
        if (other.gameObject.name == "rosepoint")
        {
            courseline.SetActive(true);
            point3.SetActive(false);
            rosetext2.SetActive(true);
            Destroy(rosetext1);
            Debug.Log("rossepointreached");
        }
    }
    
}
