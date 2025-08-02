using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public Animator transitionAnimator;
    public float transitionTime = 1f;

    public void TransitionToScene(string sceneName)
    {
        StartCoroutine(LoadScene(sceneName));
    }

    private System.Collections.IEnumerator LoadScene(string sceneName)
    {
        transitionAnimator.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneName);
    }
}
