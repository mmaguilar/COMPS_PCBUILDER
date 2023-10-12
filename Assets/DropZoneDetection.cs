using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropZoneDetection : MonoBehaviour
{
    public GameObject validAlignmentText;
    public GameObject invalidAlignmentText;

    // Start is called before the first frame update
    private void OnTriggerExit(Collider other)
    {
            invalidAlignmentText.SetActive(false);
            validAlignmentText.SetActive(false);         
    }
}
