using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random=UnityEngine.Random;
public class Jukebox : MonoBehaviour
{

    private Collision2D col;
    private bool playing;
    [SerializeField] private List<AudioClip> MusicList = new List<AudioClip>();
    [SerializeField] private GameObject text;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

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
           audioSource.Stop();
           text.SetActive(false);
        }
    }

    void Update()
    {
        if (playing && !audioSource.isPlaying)
        {
          PlayMusic();
        }
        if (Input.GetKeyDown(KeyCode.E) && col != null)
        { 
          PlayMusic();
        }
    }

    private void PlayMusic()
    {
        audioSource.Stop();
        audioSource.clip = MusicList[Random.Range(0, MusicList.Capacity)];
        audioSource.Play();
        text.GetComponent<TMP_Text>().text = "<mark=#000000AA><#ffffff>"+audioSource.clip.name+"</color></mark>";
        text.SetActive(true);
        playing = true;
        
        
        
        
         
    }
}
