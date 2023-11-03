using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RAMAlignment : MonoBehaviour
{
    public GameObject validAlignmentText;
    public GameObject InvalidAlignmentText;

    public  void Start()
    {
        validAlignmentText.SetActive(false);
        InvalidAlignmentText.SetActive(false);
    }
    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Collider")
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
}
