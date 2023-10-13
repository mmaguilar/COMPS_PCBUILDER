using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class DropZoneDetection : MonoBehaviour
{
    public GameObject validAlignmentText;
    public GameObject invalidAlignmentText;
    public XRSocketInteractor socket;
    public float waitTime;

    // Start is called before the first frame update
    private void OnTriggerExit(Collider other)
    {
       invalidAlignmentText.SetActive(false);
       validAlignmentText.SetActive(false);

       print(socket.GetOldestInteractableSelected());
        if(socket.GetOldestInteractableSelected() != null)
        {
            validAlignmentText.SetActive(false);
            StartCoroutine(LoadCPUScene());
            SceneManager.LoadScene(2);
            
        }
    }

    IEnumerator LoadCPUScene()
    {
        yield return new WaitForSeconds(waitTime);
    }
}
