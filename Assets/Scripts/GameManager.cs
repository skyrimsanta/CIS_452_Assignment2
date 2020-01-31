using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * (Levi Schoof)
 * (GameManager)
 * (Assignment 2)
 * (Handles most of the UI)
 */

public class GameManager : MonoBehaviour
{
    public Text movement;
    public Text switching;
    public Text dodge;
    public Text switchingTwo;
    public Text Instructions;
    public Text health;

    private void Start()
    {
        Instructions.enabled = true;
        movement.enabled = false;
        switching.enabled = false;
        switchingTwo.enabled = false;
        health.enabled = false;
        dodge.text = "Press Any Key";
    }

    private void Update()
    {
        if (Instructions.enabled && Input.anyKey)
        {
            Instructions.enabled = false;
            movement.enabled = true;
            switching.enabled = true;
            switchingTwo.enabled = true;
            dodge.text = "Dodge Green Things";
        }

        else if (movement.enabled && (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)))
        {
        
            movement.enabled = false;
            health.enabled = true;
        }

        else if(switching.enabled && Input.GetKey(KeyCode.Alpha1))
        {
         
            switching.enabled = false;
            switchingTwo.enabled = false;
        }
    }

}
