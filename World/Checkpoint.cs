using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Vector2 respawnPosition;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerRespawn respawn = other.GetComponent<PlayerRespawn>();
            if (respawn != null) respawn.SetCheckpoint(respawnPosition);
        }
    }
}
