using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float crashDelay = 1.0f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool crashedAlready = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground" && crashedAlready == false)
        {
            FindObjectOfType<PlayerController>().DisableControls();            
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            crashedAlready = true;            
            Invoke("ReloadScene", crashDelay);            
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene("Level1");
    }
}
