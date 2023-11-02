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

    private void OnTriggerExit(Collider other)
    {
        print(socket.GetOldestInteractableSelected());
        if (socket.GetOldestInteractableSelected() != null)
        {
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
