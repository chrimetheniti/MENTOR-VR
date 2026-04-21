using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class meshenbl : MonoBehaviour
{
    public bool pressed1;
    public bool pressed2;
    public bool pressed3;
  
    public GameObject officer4;
    public GameObject pen;
    public GameObject test;
    public AudioSource audioSource;
    public string sceneName;
    private float timer;
    public bool playAudio = false;

    void Update()
    {
        if (pressed1 == true && pressed2 == true && pressed3 == true)
        {

            officer4.GetComponent<Animator>().CrossFade("clap", 0.1f);
           pen.SetActive(false);
            MeshRenderer meshRenderer = test.gameObject.GetComponent<MeshRenderer>();
            if (meshRenderer == true)
            {
                meshRenderer.enabled = false;

            }
            audioSource.Play();
            timer = audioSource.clip.length;
            playAudio = false;
        }
        else if (!audioSource.isPlaying)
        {
            timer = audioSource.clip.length;
        }
        else if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            SceneManager.LoadScene(sceneName);
        }

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "wrong")
        {
            MeshRenderer meshRenderer = other.gameObject.GetComponent<MeshRenderer>();
            if (meshRenderer != null)
            {
                meshRenderer.enabled = true;
                
            }

            AudioSource audio = other.gameObject.GetComponent<AudioSource>();
            if (audio != null)
            {
                audio.Play();
            }
        }

        if (other.gameObject.name == "correct1")
        { 
            pressed1 = true;

            MeshRenderer meshRenderer = other.gameObject.GetComponent<MeshRenderer>();
            if (meshRenderer != null)
            {
                meshRenderer.enabled = true;

            }

            AudioSource audio = other.gameObject.GetComponent<AudioSource>();
            if (audio != null)
            {
                audio.Play();
            }
        }
        if (other.gameObject.name == "correct2")
        {
            pressed2 = true;

            MeshRenderer meshRenderer = other.gameObject.GetComponent<MeshRenderer>();
            if (meshRenderer != null)
            {
                meshRenderer.enabled = true;

            }

            AudioSource audio = other.gameObject.GetComponent<AudioSource>();
            if (audio != null)
            {
                audio.Play();
             }
        }

        if (other.gameObject.name == "correct3")
        {
            pressed3 = true;

            MeshRenderer meshRenderer = other.gameObject.GetComponent<MeshRenderer>();
            if (meshRenderer != null)
            {
                meshRenderer.enabled = true;

            }

            AudioSource audio = other.gameObject.GetComponent<AudioSource>();
            if (audio != null)
            {
                audio.Play();
            }
    }   }  
}
