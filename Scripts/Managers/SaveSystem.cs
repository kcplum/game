using UnityEngine;

public static class SaveSystem
{
    public static void SaveGame()
    {
        PlayerPrefs.SetInt("Health", GameManager.Instance.playerHealth);
        PlayerPrefs.SetString("Inventory", string.Join(",", GameManager.Instance.inventory));
        PlayerPrefs.Save();
    }

    public static void LoadGame()
    {
        if (PlayerPrefs.HasKey("Health"))
            GameManager.Instance.playerHealth = PlayerPrefs.GetInt("Health");
        if (PlayerPrefs.HasKey("Inventory"))
            GameManager.Instance.inventory = PlayerPrefs.GetString("Inventory").Split(',');
    }
}
