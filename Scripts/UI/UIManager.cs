using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text healthText;
    public Text inventoryText;

    public void UpdateHealth(int currentHealth)
    {
        healthText.text = "Health: " + currentHealth;
    }

    public void UpdateInventory(string[] items)
    {
        inventoryText.text = "Inventory: " + string.Join(", ", items);
    }
}
