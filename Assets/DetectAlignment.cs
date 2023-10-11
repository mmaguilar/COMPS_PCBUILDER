using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectAlignment : MonoBehaviour
{
    public GameObject validAlignmentText;
    public GameObject invalidAlignmentText;

    // Start is called before the first frame update
    void Start()
    {
        validAlignmentText.SetActive(false);
        invalidAlignmentText.SetActive(false);
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Lower Edge 1")
        {
           validAlignmentText.SetActive(true);
           invalidAlignmentText.SetActive(false);
        }
     
    }

    private void OnTriggerExit(Collider other)
    {
        validAlignmentText.SetActive(false);
        invalidAlignmentText.SetActive(true);
    }
}
