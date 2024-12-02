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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void Attack(GameObject player)
    {
        Collider2D[] enemy = Physics2D.OverlapCircleAll(attackPoint.transform.position, radius, enemies);
        foreach (BoxCollider2D enemyGameobject in enemy)
        {
            Debug.Log("Attack");
            enemyGameobject.GetComponent<EnemyHP>().health -= dmg;
            player.GetComponent<PlayerHP>().mana -= 5;
        }
    }
    

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(attackPoint.transform.position,radius);
    }
}

