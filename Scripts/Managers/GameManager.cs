using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int playerHealth = 100;
    public string[] inventory;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }

    public void AddItem(string item)
    {
        var items = new System.Collections.Generic.List<string>(inventory);
        items.Add(item);
        inventory = items.ToArray();
    }

    public void SetHealth(int health) => playerHealth = health;
}
