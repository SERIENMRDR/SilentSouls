using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class AttackTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public float dmg;
    public GameObject attackPoint;
    public float radius;
    public LayerMask enemies;
    public PlayerHP player;
    
    public void Attack()
    {
        if (player.mana >= 5)
        {
            player.mana -= 5;
            Collider2D[] enemy = Physics2D.OverlapCircleAll(attackPoint.transform.position, radius, enemies);
            foreach (Collider2D enemyGameobject in enemy)
            {
                enemyGameobject.GetComponent<EnemyHP>().health -= dmg;
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(attackPoint.transform.position,radius);
    }
}

