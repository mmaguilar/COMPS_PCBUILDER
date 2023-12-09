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
     
    //display text objects on collision enter
    private void OnTriggerExit(Collider other)
    {
       invalidAlignmentText.SetActive(false);
       validAlignmentText.SetActive(false);

        //verify object in the drop zone
        //transition into new scene
        if(socket.GetOldestInteractableSelected() != null)
        {
            validAlignmentText.SetActive(false);
            GoToScene(SceneToTransition);
            
        }
    }

    //transition to new scene
    public void GoToScene(int scene)
    {
        StartCoroutine(GoToSceneRoutine(scene));
    }

    //fade into scene
    IEnumerator GoToSceneRoutine(int scene)
    {
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);

        //Launch the new Scene 
        SceneManager.LoadScene(scene);
    }

}
