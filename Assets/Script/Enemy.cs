using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rb;


    public int Health = 100;

    public int ene;
    // public GameObject DeathEffect;
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    private void Start()
    {
        ene= EnemySpawner.finalenemy;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;

        if(Health <= 60 ){
           rb.gravityScale = 45;
        }

        if (Health <= 0)
        {
            EnemySpawner.finalenemy--;
            Die();
        }


    }

    void Die()
    {
        // Instantiate(DeathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
