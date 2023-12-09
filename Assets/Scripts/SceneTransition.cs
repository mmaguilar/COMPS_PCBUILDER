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

    //wait to transition into a new scene 
    IEnumerator InstructionsScene()
    {
        yield return new WaitForSeconds(sceneTime);
        GoToScene(nextScene);
    }

    //transition to a new scene
    public void GoToScene(int scene)
    {
        StartCoroutine(GoToSceneRoutine(scene));
    }

    //fade into a new scene 
    IEnumerator GoToSceneRoutine(int scene)
    {
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);

        //Launch the new Scene 
        SceneManager.LoadScene(scene);
    }

}
