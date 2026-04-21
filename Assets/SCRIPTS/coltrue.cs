using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coltrue : MonoBehaviour
{
    public  bool istrue;
    
    public GameObject arrow;

    private void OnTriggerStay(Collider other)
    {
        if(other .gameObject.name== "BodyCollider")
        {
            istrue=true;
            Debug.Log("istrue");
           arrow.SetActive(true);
            
        }
    }
}
