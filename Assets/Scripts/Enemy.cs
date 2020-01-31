using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern
{
    public abstract class Enemy : MonoBehaviour
    {

        public IAttack AttackBehavior { get; set; }
        public IMovement MovementBehavior { get; set; }
        [HideInInspector]  public Player player;

        public virtual void Move() {MovementBehavior.Movement();}
        public virtual void Attack() { AttackBehavior.Attack();}
        public abstract void SwitchSide();

        private void Start()
        {
            player = FindObjectOfType<Player>();
        }


        private void FixedUpdate()
        {
            if (Vector2.Distance(this.transform.position, player.transform.position) < 7)
            {
                Move();
                Attack();
            }
        }


        private void Update()
        {
            SwitchSide();
        }


        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                collision.gameObject.GetComponent<Player>().TakeDamage();
                Destroy(this.gameObject);
            }
        }

    }
}
