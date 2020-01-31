using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * (Levi Schoof)
 * (Bullet)
 * (Assignment 2)
 * (Manages the basic behavior of the bullets)
 */

public class Bullet : MonoBehaviour
{
    private float time;
    private void Start()
    {
        time = 0;
        Invoke("KillThis", 3);
    }
    private void Update()
    {
        time += Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") && time > .5f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") && time > .5f)
        {
            Destroy(this.gameObject);
        }
    }

    private void KillThis()
    {
        Destroy(this.gameObject);
    }
}
