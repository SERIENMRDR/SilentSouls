using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyHP : MonoBehaviour
{
    public float health;
    public float maxHealth;


    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update() { 

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}

