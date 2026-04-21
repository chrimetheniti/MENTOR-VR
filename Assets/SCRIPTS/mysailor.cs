using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class mysailor : MonoBehaviour
{
    public Text timer;
    float currentvalue;


    private void Start()
    {
        currentvalue = 30f;
    }


    private void Update()
    {
        currentvalue -= 1* Time.deltaTime;
        timer.text = currentvalue.ToString( "0");
        if (currentvalue <= 0)
        {
            timer.text = "0";
        }

    }



}

