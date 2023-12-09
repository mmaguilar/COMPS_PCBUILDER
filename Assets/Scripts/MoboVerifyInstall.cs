using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoboVerifyInstall : MonoBehaviour
{
    public GameObject completedText1;
    public GameObject completedText2;
    public GameObject completedText3;
    public GameObject completedText4;
    public GameObject completedText5;
    public GameObject completedText6;

    public GameObject completedInstallText;

    public FadeScreen fadeScreen;
    public int SceneToTransition;

    private void Start()
    {
        completedInstallText.SetActive(false);
    }
    private void Update()
    {
        //update text objects when install is complete 
        //transition to new scene 
        if(completedText1.activeSelf && completedText2.activeSelf && completedText3.activeSelf
            && completedText4.activeSelf && completedText5.activeSelf && completedText6.activeSelf)
        {
            completedText1.SetActive(false);
            completedText2.SetActive(false);
            completedText3.SetActive(false);
            completedText4.SetActive(false);
            completedText5.SetActive(false);
            completedText6.SetActive(false);
            completedInstallText.SetActive(true);
            GoToScene(SceneToTransition);
        } 
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
