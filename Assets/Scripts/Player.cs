using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Range(1, 500)] [SerializeField] private float speed;
    [SerializeField] private Animator _animator;
    [SerializeField] private float timeToReach;

    private float horizontal;
    private float vertical;
    private Rigidbody2D rb;
    private float timer;
    private Collision2D col;
    private bool playing;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        flip();
        if (horizontal == 0 && vertical == 0)
        {
            if (timeToReach <= timer)
            {
                _animator.SetBool("IsIdle", true);
                Debug.Log("idle");
                timer = 0;
            }
            else
            {
                if (_animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
                {
                    _animator.SetBool("IsIdle", false);
                }

                timer += Time.deltaTime;
            }
        }
        else
        {
            timer = 0;
            _animator.SetBool("IsIdle", false);
        }

       
    }

    private void FixedUpdate()
    {
        rb.velocity = Vector2.ClampMagnitude(new Vector2(horizontal, vertical) * speed * Time.deltaTime, speed);
    }

    private void flip()
    {
        _animator.SetBool("IsWalkingLeft", horizontal < 0f);
        _animator.SetBool("IsWalkingRight", horizontal > 0f);
        _animator.SetBool("IsWalkingDown", vertical < 0f);
        _animator.SetBool("IsWalkingTop", vertical > 0f);
    }

   
}