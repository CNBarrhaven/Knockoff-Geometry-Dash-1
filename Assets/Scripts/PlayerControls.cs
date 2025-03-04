﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float jumpPower = 6f;
    public bool isGrounded;
    float posX;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        posX = transform.position.x;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) 
        { 
            rb.AddForce(Vector3.up * jumpPower * rb.mass * rb.gravityScale * 20f);

        }

        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            rb.AddForce(Vector3.up * jumpPower * rb.mass * rb.gravityScale * 20f);

        }

        if (transform.position.x < posX) 
            {
                GameOver();
            }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
        if (collision.gameObject.tag == "Enemy")
        {
            GameOver();
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
    void GameOver()
    {
        GameObject.Find("GameController").GetComponent<GameController>().GameOver();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            GameObject.Find("GameController").GetComponent<GameController>().IncrementScore();
            Destroy(collision.gameObject);  
        }
    }
}
