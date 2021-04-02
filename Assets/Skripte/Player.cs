using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int maxHealth = 100;
    public int minHealth = 0;
    public int currentHealth;
    public Healthbar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            TakeDamage(15);        
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            Heal(15);                   
        }



    }
    void TakeDamage(int damge)
    {
        currentHealth -= damge;
        if (currentHealth < minHealth)
        {
            currentHealth = minHealth;
        }
        healthBar.SetHealth(currentHealth);
    }

    void Heal(int healValue)
    {
        currentHealth += healValue;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        healthBar.SetHealth(currentHealth);
    }
}