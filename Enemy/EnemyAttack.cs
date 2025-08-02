using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int damage = 10;
    public float attackCooldown = 1f;
    private float lastAttackTime;

    void OnCollisionStay2D(Collision2D collision)
    {
        if (Time.time - lastAttackTime < attackCooldown) return;
        Damageable target = collision.collider.GetComponent<Damageable>();
        if (target != null)
        {
            target.TakeDamage(damage);
            lastAttackTime = Time.time;
        }
    }
}
