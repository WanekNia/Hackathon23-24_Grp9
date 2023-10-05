using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jukebox : MonoBehaviour
{

    private Collision2D col;
    private bool playing;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
        {
            col = other;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
        {
            col = null;
            gameObject.transform.GetChild(0).gameObject.SetActive(false);

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (playing)
        {
            playing = false;
            GetComponent<AudioSource>().Stop();

        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.E) && col != null && !playing)
        {
            GetComponent<AudioSource>().Play();
            playing = true;
        }
    }
}
