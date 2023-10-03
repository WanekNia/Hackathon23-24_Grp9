using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Range(1, 300)] [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;
    private float horizontal;
    private float vertical;
    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = Vector2.ClampMagnitude(new Vector2(horizontal, vertical) * speed, speed);
    }
}