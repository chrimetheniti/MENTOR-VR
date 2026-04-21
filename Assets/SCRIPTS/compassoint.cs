using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class compassoint : MonoBehaviour
{
    public GameObject miles0;
    public GameObject miles1;
    public GameObject miles2;
    public GameObject miles3;
    public GameObject miles4;
    public GameObject miles5;
    public GameObject miles6;
    public GameObject miles7;
    public GameObject milestext;

    public GameObject milesline1;
    public GameObject milesline2;
    public GameObject milesline3;
    public GameObject milesline4;
    public GameObject milesline5;
    public GameObject milesline6;
    public GameObject milesline7;
    public GameObject compassotext;
    public GameObject rosetext1;
    public GameObject compassrose;
    public bool click1;
    public bool click2;
    public bool click3;
    public bool click4;
    public bool click5;
    public bool click6;
    public bool click7;
    public bool click8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (click1 == true && click2 == true)
        {
            milesline1.SetActive(true);
        }

        if (click2 == true && click3 == true)
        {
            milesline2.SetActive(true);

        }

        if (click3 == true && click4 == true)
        {
            milesline3.SetActive(true);
        }

        if (click4 == true && click5 == true)
        {
            milesline4.SetActive(true);
        }

        if (click5 == true && click6 == true)
        {
            milesline5.SetActive(true);
        }

        if (click6 == true && click7 == true)
        {
            milesline6.SetActive(true);
        }

        if (click7 == true && click8 == true)
        {
            milesline7.SetActive(true);
            rosetext1.SetActive(true);
            compassrose.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "miles0")
        {
            click1 = true;

        }

        if (other.gameObject.name == "miles1")
        {
            click2 = true;

        }

        if (other.gameObject.name == "miles2")
        {
            click3 = true;

        }
        if (other.gameObject.name == "miles3")
        {
            click4 = true;

        }
        if (other.gameObject.name == "miles4")
        {
            click5 = true;

        }
        if (other.gameObject.name == "miles5")
        {
            click6 = true;

        }
        if (other.gameObject.name == "miles6")
        {
            click7 = true;

        }
        if (other.gameObject.name == "miles7")
        {
            click8 = true;

        }
    }
    public void showmiles()
    {
        miles0.SetActive(true);
        miles1.SetActive(true);
        miles2.SetActive(true);
        miles3.SetActive(true);
        miles4.SetActive(true);
        miles5.SetActive(true);
        miles6.SetActive(true);
        miles7.SetActive(true);
        milestext.SetActive(true);
        Destroy(compassotext);
    }
}

