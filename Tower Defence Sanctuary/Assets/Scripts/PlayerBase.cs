using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBase : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public Playerhealthbar healthbar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.setmaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void takeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.setHealth(currentHealth);

        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
    }

    public void healDamage(int heal)
    {
        currentHealth += heal;
        healthbar.setHealth(currentHealth);

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}
