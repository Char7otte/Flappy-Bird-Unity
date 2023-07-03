using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;

    public float gravityStrength;
    public float flapStrength;

    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = gravityStrength;

        Time.timeScale = 1.0f;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            audioSource.Play();

            rb.velocity = Vector2.up * flapStrength;
        }      
    }
}
