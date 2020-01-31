using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * (Levi Schoof)
 * (Enemy Attacks)
 * (Assignment 2)
 * (Holds the two kinds of enemy attack classes, and implements the IAttack abstract class)
 */

namespace StrategyPattern
{

    public class NoAttack : IAttack
    {
        public override void Attack()
        {
            Debug.Log("This Enemy does not attack");
        }
    }

    public class FireBullets: IAttack
    {
        float attackSpeed = 2;
        float currentTime = 0;

        private Player player;
        GameObject bulletPrefab;

        private void Start()
        {
            currentTime = 0;
            player = FindObjectOfType<Player>();
            bulletPrefab = (Resources.Load("Bullet") as GameObject);
        }

        private void Awake()
        {
            currentTime = 0;
        }


        private void Update()
        {
            currentTime += Time.deltaTime;
        }

        public override void Attack()
        {
            if(currentTime > attackSpeed)
            {
                currentTime = 0;
                GameObject bullet = Instantiate(bulletPrefab, this.transform.position, Quaternion.identity);
                bullet.GetComponent<Rigidbody2D>().velocity = (player.transform.position - bullet.transform.position).normalized * 5;
            }
        }
    }

}
