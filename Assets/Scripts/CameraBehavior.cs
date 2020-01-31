using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * (Levi Schoof)
 * (CameraBehavior)
 * (Assignment 2)
 * (Handles the movement of the camera, so it follows the player)
 */

public class CameraBehavior : MonoBehaviour
{
    Player player;
    Vector3 tempPos;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        tempPos = transform.position;
        tempPos.x = player.gameObject.transform.position.x;
        transform.position = tempPos;
    }
}
