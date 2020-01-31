using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
