using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBase : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            takeDamage(20);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            healDamage(20);
        }
    }

    public void takeDamage(int damage)
    {
        currentHealth -= damage;
    }

    public void healDamage(int heal)
    {
        currentHealth += heal;
    }
}
