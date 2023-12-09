using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class GPUAlignment : MonoBehaviour
{
    public GameObject validAlignmentText;
    public GameObject InvalidAlignmentText;

    public FadeScreen fadeScreen;
    public XRSocketInteractor socket;

    public float waitTime;
    public int SceneToTransition;

    //hide text objects when scene begins
    public void Start()
    {
        validAlignmentText.SetActive(false);
        InvalidAlignmentText.SetActive(false);
    }

    //verify when object in drop zone
    //transition to new scene
    public void Update()
    {
        if (socket.GetOldestInteractableSelected() != null)
        {
            GoToScene(SceneToTransition);
        }
    }

    //display text objects on collision stay 
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Collider")
        {
            validAlignmentText.SetActive(true);
            if (InvalidAlignmentText.activeSelf)
            {
                InvalidAlignmentText.SetActive(false);
            }
        }
    }

    //update text objects on collision exits 
    public void OnTriggerExit(Collider other)
    {
        InvalidAlignmentText.SetActive(true);
        validAlignmentText.SetActive(false);
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

