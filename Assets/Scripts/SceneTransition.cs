using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public int nextScene;
    public FadeScreen fadeScreen;
    public int sceneTime;

    private void Start()
    {
        StartCoroutine(InstructionsScene());
    }

    IEnumerator InstructionsScene()
    {
        yield return new WaitForSeconds(sceneTime);
        GoToScene(nextScene);
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
