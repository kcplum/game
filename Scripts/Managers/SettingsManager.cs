using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
        PlayerPrefs.SetFloat("Volume", volume);
    }

    public void LoadSettings()
    {
        if (PlayerPrefs.HasKey("Volume"))
            AudioListener.volume = PlayerPrefs.GetFloat("Volume");
    }
}
