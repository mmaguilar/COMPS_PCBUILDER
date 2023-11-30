using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class WiresVerifyInstall : MonoBehaviour
{
   public GameObject completedInstallText;

    public FadeScreen fadeScreen;
    public XRSocketInteractor socket1;
    public XRSocketInteractor socket2;
    public XRSocketInteractor socket3;
    public XRSocketInteractor socket4;
    public XRSocketInteractor socket5;
    public XRSocketInteractor socket6;
    public XRSocketInteractor socket7;
    public XRSocketInteractor socket8;
    public XRSocketInteractor socket9;
    
    public float waitTime;
    public int SceneToTransition;

    public void Start()
    {
        completedInstallText.SetActive(false);
    }
    public void Update()
    {
        if (socket1.GetOldestInteractableSelected() != null && socket2.GetOldestInteractableSelected() != null && socket3.GetOldestInteractableSelected() != null
           && socket4.GetOldestInteractableSelected() != null && socket5.GetOldestInteractableSelected() != null && socket6.GetOldestInteractableSelected() != null
           && socket7.GetOldestInteractableSelected() != null && socket8.GetOldestInteractableSelected() != null && socket9.GetOldestInteractableSelected() != null)
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
