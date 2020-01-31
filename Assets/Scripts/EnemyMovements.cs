using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
