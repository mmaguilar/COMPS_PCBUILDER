using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class VerifyMonitorInstall1 : MonoBehaviour
{
    public XRSocketInteractor hdmi;
    public XRSocketInteractor power;

    public FadeScreen fadeScreen;
    public int SceneToTransition;

    public GameObject completedInstallText;

    void Start()
    {
        completedInstallText.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
       if(hdmi.GetOldestInteractableSelected() != null && power.GetOldestInteractableSelected() != null)
        {
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
