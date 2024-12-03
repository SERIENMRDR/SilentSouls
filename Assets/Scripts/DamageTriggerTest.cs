using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTriggerTest : MonoBehaviour
{
    public float dmg;
    public PlayerHP playerHP;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerHP.health -= dmg;
        }
    }
}
