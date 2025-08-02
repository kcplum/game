using UnityEngine;

public class CombatSystem : MonoBehaviour
{
    public int damage = 25;
    public float attackRange = 1f;
    public LayerMask enemyLayer;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            Attack();
    }

    void Attack()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(transform.position, attackRange, enemyLayer);
        foreach (Collider2D enemy in hitEnemies)
        {
            Damageable dmg = enemy.GetComponent<Damageable>();
            if (dmg != null) dmg.TakeDamage(damage);
        }
    }
}
