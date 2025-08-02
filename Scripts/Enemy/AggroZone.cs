using UnityEngine;

public class AggroZone : MonoBehaviour
{
    public EnemyController enemy;
    public Transform player;
    public float chaseSpeed = 3f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            StartChase();
    }

    void StartChase()
    {
        if (enemy != null && player != null)
        {
            enemy.GetComponent<Rigidbody2D>().velocity = (player.position - enemy.transform.position).normalized * chaseSpeed;
        }
    }
}
