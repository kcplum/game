using UnityEngine;

public class CutsceneManager : MonoBehaviour
{
    public GameObject[] cutsceneSteps;
    private int currentStep = 0;

    public void PlayNextStep()
    {
        if (currentStep < cutsceneSteps.Length)
            cutsceneSteps[currentStep++].SetActive(true);
    }

    public void ResetCutscene()
    {
        foreach (var step in cutsceneSteps) step.SetActive(false);
        currentStep = 0;
    }
}
