using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
 * (Levi Schoof)
 * (Player)
 * (Assignment 2)
 * (Handles all the behvior of the player, including movement and health)
 */

public class Player : MonoBehaviour
{
    public Text healthText;
    public float speed = 20;
    private float gravityNum = -1;
    private Rigidbody2D rb;
    bool switching = false;
    private float health = 3;
    private float currentTime = 0;
    public Text endText;

    private void Start()
    {
        Time.timeScale = 1;
        gravityNum = -1;
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void Update()
    {
        currentTime += Time.deltaTime;
        SwitchSides();
        if(Time.timeScale ==0 & Input.anyKeyDown)
        {
            Restart();
        }
    }

    private void Movement()
    {
        
        float h = Input.GetAxis("Horizontal");

        Vector3 tempVect = new Vector3(h, gravityNum, 0);
        tempVect = tempVect.normalized * speed * Time.deltaTime;
        rb.MovePosition(rb.transform.position + tempVect);
    }

    private void SwitchSides()
    {
        if (!switching)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1) && currentTime > .5f && gravityNum > 0)
            {
                currentTime = 0;
                switching = true;
                gravityNum = -1;
            }

            if (Input.GetKeyDown(KeyCode.Alpha2) && currentTime > .5f && gravityNum < 0)
            {
                currentTime = 0;
                switching = true;
                gravityNum = 1;
            }
        }
   
    }

    public void TakeDamage()
    {
        health--;
        healthText.text = "Health: " + health;
        if(health <= 0)
        {
            endText.text = "You Lost, press any button to restart";
            Time.timeScale = 0;
            //Destroy(this.gameObject);
        }
    }

    private void Restart()
    {
        SceneManager.LoadScene(0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            switching = false;
        }

        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            TakeDamage();
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
           // switching = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("End"))
        {
            endText.text = "You Won, press any button to restart";
            Time.timeScale = 0;
        }
    }
}
