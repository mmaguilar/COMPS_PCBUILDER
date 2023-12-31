using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSupplyAlignment : MonoBehaviour
{
    public GameObject validAlignmentText;
    public GameObject InvalidAlignmentText;

    //disable text objects when scene begins
    public void Start()
    {
        validAlignmentText.SetActive(false);
        InvalidAlignmentText.SetActive(false);
    }

    //update objects on collision stay 
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

    //update objects when collision exited
    public void OnTriggerExit(Collider other)
    {
        InvalidAlignmentText.SetActive(true);
        validAlignmentText.SetActive(false);
    }
}
