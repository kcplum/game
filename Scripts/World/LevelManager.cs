using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadLevel(string sceneName) => SceneManager.LoadScene(sceneName);
    public void ReloadCurrentLevel() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
