using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//script for the option to go back to the previous scene 

public class GoBackScript : MonoBehaviour
{
    public FadeScreen fadeScreen;
    public int SceneToTransition;

    public void GoBackScene()
    {
        GoToScene(SceneToTransition);
    }

    //transition to new scene
    public void GoToScene(int scene)
    {
        StartCoroutine(GoToSceneRoutine(scene));
    }

    //fade into new scene
    IEnumerator GoToSceneRoutine(int scene)
    {
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);

        //Launch the new Scene 
        SceneManager.LoadScene(scene);
    }
}
