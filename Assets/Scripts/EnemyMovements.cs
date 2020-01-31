using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * (Levi Schoof)
 * (EnemyMovements)
 * (Assignment 2)
 * (Holds the two kinds of enemy movements classes, and implements the IMovement abstract class)
 */

namespace StrategyPattern
{
    public class NoMove : IMovement
    {
        public override void Movement()
        {
            Debug.Log("Does Not Move");
        }
    }

    public class LeftRightMovement : IMovement
    {
        Vector3 target;
        Vector3 temp;
        public override void Movement()
        {
            target = FindObjectOfType<Player>().gameObject.transform.position;
            target.y = this.gameObject.transform.position.y;

            temp = transform.position;
            if (target.x < transform.position.x)
            {
                temp.x += -1 * Time.deltaTime;
                transform.position = temp;
            }

            else if (target.x > transform.position.x)
            {
                temp.x += 1 * Time.deltaTime;
                transform.position = temp;
            }
        }
    }
}
