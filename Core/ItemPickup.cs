using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public string itemName;

    void OnTriggerEnter2D(Collider2D other)
    {
        Inventory inv = other.GetComponent<Inventory>();
        if (inv != null)
        {
            inv.AddItem(itemName);
            Destroy(gameObject);
        }
    }
}
