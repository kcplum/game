using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float speed = 2f;
    private int currentPointIndex = 0;

    void Update()
    {
        if (patrolPoints.Length == 0) return;
        Transform targetPoint = patrolPoints[currentPointIndex];
        transform.position = Vector2.MoveTowards(transform.position, targetPoint.position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, targetPoint.position) < 0.1f)
            currentPointIndex = (currentPointIndex + 1) % patrolPoints.Length;
    }
}
