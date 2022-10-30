using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;

    public Rigidbody2D rb;

    // public GameObject Impact;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
         Destroy(gameObject,2f);

    }

    // Update is called once per frame
    void Update()
    {

    }
    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D hitinfo)
    {
        Enemy enemy = hitinfo.GetComponent<Enemy>();
        if(enemy !=null)
        {
            enemy.TakeDamage(damage);

        Destroy(gameObject);
        }
        // Instantiate(impact ,transform.position,transform.rotation);
    }
}
