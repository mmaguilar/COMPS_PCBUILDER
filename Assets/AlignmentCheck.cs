using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class AlignmentCheck : MonoBehaviour
{
    public GameObject invalidAlignText;
    public GameObject validAlignText;
    public GameObject ColliderObject;
    public XRSocketInteractor dropZone;

    //public float zConstraint;

    private void Start()
    {
        invalidAlignText.SetActive(false);
        validAlignText.SetActive(false);
    }
    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "CPU Drop Zone")
        {
            //print("CPU tranform: " + ColliderObject.transform.rotation);
            //print("Motherboard tranform" + other.transform.rotation);

            print(ColliderObject.transform.rotation.eulerAngles.x - other.transform.rotation.eulerAngles.x);
            print(ColliderObject.transform.rotation.eulerAngles.y - other.transform.rotation.eulerAngles.y);
            print(ColliderObject.transform.rotation.eulerAngles.z - other.transform.rotation.eulerAngles.z);

            if(ColliderObject.transform.rotation.eulerAngles.x < 10 && ColliderObject.transform.rotation.eulerAngles.y > 10)
            {

                invalidAlignText.SetActive(false);
                validAlignText.SetActive(true);

            }
            else
            {
                invalidAlignText.SetActive(true);
                validAlignText.SetActive(false);
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "CPU Drop Zone")
        {
            invalidAlignText.SetActive(false);
            validAlignText.SetActive(false);
        }
    }
}
