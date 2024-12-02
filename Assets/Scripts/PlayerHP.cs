using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public Slider healthBar;


    public  float mana;
    public  float maxMana;
    public Slider manaBar;


    // Start is called before the first frame update
    void Start()
    {   
        health = maxHealth;
        healthBar.maxValue = maxHealth;
        mana = maxMana;
        manaBar.maxValue = maxMana;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = health;
        healthBar.maxValue = maxHealth;
        manaBar.value = mana;
        manaBar.maxValue = maxMana;


        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
