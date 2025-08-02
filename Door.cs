using UnityEngine;

public class Door : MonoBehaviour
{
    public bool isLocked = true;
    public Animator animator;

    public void Unlock()
    {
        isLocked = false;
        animator.SetTrigger("Open");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!isLocked && other.CompareTag("Player"))
        {
            // Transition to next area
        }
    }
}
