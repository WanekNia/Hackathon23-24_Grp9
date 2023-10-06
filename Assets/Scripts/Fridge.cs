using System;
using UnityEngine;

public class Fridge : MonoBehaviour
{
    private Collision2D col;
    private bool isOpen;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            col = other;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            col = null;
            GetComponent<Animator>().SetBool("PlayerInteract", true);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && col != null)
        {
            isOpen = !isOpen;
            
            GetComponent<Animator>().SetBool("IsOpen", isOpen);
            GetComponent<Animator>().SetBool("PlayerInteract", true);

        }
    }
}