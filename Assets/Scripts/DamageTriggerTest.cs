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
            InvokeRepeating("Attack", 0f, 1.0f);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            CancelInvoke("Attack");
        }
    }

    public void Attack()
    {
            playerHP.health -= dmg;
    }
}
