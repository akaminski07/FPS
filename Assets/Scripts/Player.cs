using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

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
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    TakeDamage(20);
        //}
        if (currentHealth <= 0) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("NPC") && collision.collider is CapsuleCollider)
        {

            TakeDamage(12);
        }
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

}
