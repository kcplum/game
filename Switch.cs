using UnityEngine;

public class Switch : Interactable
{
    public Door linkedDoor;

    public override void Interact() { linkedDoor?.Unlock(); }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) Interact();
    }
}
