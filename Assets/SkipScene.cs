using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipScene : MonoBehaviour
{
    public FadeScreen fadeScreen;
    public int SceneToTransition;

    public void NextScene()
    {
        GoToScene(SceneToTransition);
    }

    public void GoToScene(int scene)
    {
        StartCoroutine(GoToSceneRoutine(scene));
    }

    IEnumerator GoToSceneRoutine(int scene)
    {
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);

        //Launch the new Scene 
        SceneManager.LoadScene(scene);
    }
}
