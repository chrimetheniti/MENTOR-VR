using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class hourglassint : MonoBehaviour
{
    public TextMeshProUGUI timer;
    public float currenttime;
    public GameObject officer;
    public GameObject text;
    private coltrue scriptcol;
    public GameObject hourglass;
    public GameObject officer3;
    public GameObject teleof3;
    public GameObject officer4;
    public GameObject pen;
    public GameObject test;
    // Start is called before the first frame update
    void Start()
    {
        scriptcol = GetComponent<coltrue>();
        currenttime = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        if (scriptcol.istrue)
        {
            if (transform.eulerAngles.z >= 60 && transform.eulerAngles.z <= 90)
            {
                 Debug.Log("is true");
                hourglass.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY;
                hourglass.transform.rotation = Quaternion.Euler(0f, 0f, 180f);
                text.SetActive(true);
                officer.GetComponent<Animation>();


            }
            if (transform.eulerAngles.z >= 170 && transform.eulerAngles.z <= 190)
            {
                Debug.Log("time");
                currenttime -= 1 * Time.deltaTime;
                timer.text = currenttime.ToString("0");
                hourglass.gameObject.GetComponent<AudioSource>().Play();
                if (currenttime <= 0)
                {
                    Destroy(hourglass);
                    Destroy(officer3);
                    officer4.SetActive(true);
                    pen.SetActive(true);
                    test.SetActive(true);   
                }
            }

        }


    }
    public void penonhand()
    {
        officer3.SetActive(true);
        teleof3.SetActive(true);
    }
}


