using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectAlignment : MonoBehaviour
{
    public GameObject validAlignmentText;
    public GameObject invalidAlignmentText;

    // Start is called before the first frame update
    //hide text objects when scene begins
    void Start()
    {
        validAlignmentText.SetActive(false);
        invalidAlignmentText.SetActive(false);
    }

    //display text objects on collision enter
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Lower Edge 1")
        {
            validAlignmentText.SetActive(true);
            invalidAlignmentText.SetActive(false);
        }
       
    }

    //display text on collision stay
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Lower Edge 1")
        {
           validAlignmentText.SetActive(true);
           invalidAlignmentText.SetActive(false);
        }
           
    }

    //display text objects on collision exit
    private void OnTriggerExit(Collider other)
    {
        validAlignmentText.SetActive(false);
        invalidAlignmentText.SetActive(true);
    }
}
