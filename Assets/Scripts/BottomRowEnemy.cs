using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * (Levi Schoof)
 * (BottomRowEnemy)
 * (Assignment 2)
 * (The basic enemy that works on the bottom row. Implements the Enemy Abstract Class)
 */


namespace StrategyPattern
{
    public class BottomRowEnemy : Enemy
    {
        private void Awake()
        {
            AttackBehavior = gameObject.AddComponent<NoAttack>();
            MovementBehavior = gameObject.AddComponent<LeftRightMovement>();
        }

        public override void SwitchSide()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                if(GetComponent<NoAttack>() == null)
                {
                    AttackBehavior = gameObject.AddComponent<NoAttack>();
                }

                else
                {
                    AttackBehavior = GetComponent<NoAttack>();
                }

                if(GetComponent<LeftRightMovement>() == null)
                {
                    MovementBehavior = gameObject.AddComponent<LeftRightMovement>();
                }

                else
                {
                    MovementBehavior = GetComponent<LeftRightMovement>();
                }
          
              
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                if(GetComponent<FireBullets>() == null)
                {
                    AttackBehavior = gameObject.AddComponent<FireBullets>();
                }

                else
                {
                    AttackBehavior = GetComponent<FireBullets>();
                }
           
                if(GetComponent<NoMove>() == null)
                {
                    MovementBehavior = gameObject.AddComponent<NoMove>();
                }

                else
                {
                    MovementBehavior = GetComponent<NoMove>();
                }
            }
        }
    }


}
