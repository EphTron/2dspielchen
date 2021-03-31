using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int maxHealth = 100;
    public int currntHealth;
    public Healthbar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currntHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            TakeDamage(20);        
        }        
    }
    void TakeDamage(int damge)
    {
        currntHealth -= damge;
        healthBar.SetHealth(currntHealth);
    }

}