using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GPUVerifyInstall : MonoBehaviour
{
    public GameObject completedText1;
    public GameObject completedText2;

    public GameObject completedInstallText;

    public FadeScreen fadeScreen;
    public int SceneToTransition;


    //disable text objects 
    private void Start()
    {
        completedInstallText.SetActive(false);
    }

    //verify & update text objects and transition to new scene
    private void Update()
    {
        if (completedText1.activeSelf && completedText2.activeSelf)
        {
            completedText1.SetActive(false);
            completedText2.SetActive(false);
            completedInstallText.SetActive(true);
            GoToScene(SceneToTransition);
        }
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
