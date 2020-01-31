using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * (Levi Schoof)
 * (EnemyInterfaces)
 * (Assignment 2)
 * (The Abstract classes that handle the movement and attack of the enemies)
 */

namespace StrategyPattern
{
    public abstract class IAttack: MonoBehaviour
    {
       public abstract void Attack();
    }

    public abstract class IMovement: MonoBehaviour
    {
        public abstract void Movement();
    }
}
