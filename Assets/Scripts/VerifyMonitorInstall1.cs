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
    // verify objects in drop zone and transition to a new sccene 
    void Update()
    {
       if(hdmi.GetOldestInteractableSelected() != null && power.GetOldestInteractableSelected() != null)
        {
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
