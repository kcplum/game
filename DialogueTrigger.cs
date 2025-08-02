using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public string[] dialogueLines;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            DialogueManager.Instance.StartDialogue(dialogueLines);
    }
}
