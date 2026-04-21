using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class grabpencil : MonoBehaviour
{
    public GameObject point1;
    public GameObject point2;
    public GameObject penciltext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void showpoints()
    {
        point1.SetActive(true);
        point2.SetActive(true);
        penciltext.SetActive(false);
    }
}
