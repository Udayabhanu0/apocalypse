using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{   public int maxHealth =100;
    public int currentHealth;
    public Rigidbody2D rb;
    public GameOverScript GameOver;

  


    public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
       if(currentHealth<0){
        rb.bodyType = RigidbodyType2D.Static;
        GameOver.Setup();
       }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.CompareTag("Enemy"))
         {
           
             TakeDamage(5);
           
        }
       
    }
   

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

}
