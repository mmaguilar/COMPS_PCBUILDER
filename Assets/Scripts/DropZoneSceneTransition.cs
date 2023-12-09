using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class DropZoneSceneTransition : MonoBehaviour
{
    public FadeScreen fadeScreen;
    public XRSocketInteractor socket;

    public float waitTime;
    public int SceneToTransition;

    //verify object in drop zone
    //transition to new scene
    private void OnTriggerExit(Collider other)
    {
        if (socket.GetOldestInteractableSelected() != null)
        {
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
