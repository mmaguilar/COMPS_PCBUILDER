using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class DropZoneDetection : MonoBehaviour
{
    public FadeScreen fadeScreen;
    public GameObject validAlignmentText;
    public GameObject invalidAlignmentText;
    public XRSocketInteractor socket;
    public float waitTime;
    public int SceneToTransition;
     

    private void OnTriggerExit(Collider other)
    {
       invalidAlignmentText.SetActive(false);
       validAlignmentText.SetActive(false);

       print(socket.GetOldestInteractableSelected());
        if(socket.GetOldestInteractableSelected() != null)
        {
            validAlignmentText.SetActive(false);
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
