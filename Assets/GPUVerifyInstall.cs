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


    private void Start()
    {
        completedInstallText.SetActive(false);
    }
    private void Update()
    {
        if (completedText1.activeSelf && completedText2.activeSelf)
        {
            print("Install complete");
            completedText1.SetActive(false);
            completedText2.SetActive(false);
            completedInstallText.SetActive(true);
            GoToScene(SceneToTransition);
        }
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
