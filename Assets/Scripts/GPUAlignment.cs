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

    public void Start()
    {
        validAlignmentText.SetActive(false);
        InvalidAlignmentText.SetActive(false);
    }

    public void Update()
    {
        if (socket.GetOldestInteractableSelected() != null)
        {
            GoToScene(SceneToTransition);
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Collider")
        {
            validAlignmentText.SetActive(true);
            if (InvalidAlignmentText.activeSelf)
            {
                InvalidAlignmentText.SetActive(false);
            }
            print("Aligned");
        }
    }

    public void OnTriggerExit(Collider other)
    {
        InvalidAlignmentText.SetActive(true);
        validAlignmentText.SetActive(false);
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

