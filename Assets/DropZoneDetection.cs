using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DropZoneDetection : MonoBehaviour
{
    public GameObject validAlignmentText;
    public GameObject invalidAlignmentText;
    public XRSocketInteractor socket;

    // Start is called before the first frame update
    private void OnTriggerExit(Collider other)
    {
       invalidAlignmentText.SetActive(false);
       validAlignmentText.SetActive(false);

        print(socket.GetOldestInteractableSelected());
    }
}
