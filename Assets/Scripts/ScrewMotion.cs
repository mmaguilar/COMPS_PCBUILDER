using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class ScrewMotion : MonoBehaviour
{
    public GameObject screwdriverObject;
    public GameObject boltObject;

    public float rotateSpeed;
    public float moveSpeed;

    public GameObject previousStopText;
    public GameObject previousInstructionsText;
    public GameObject previousPointer;

    public GameObject currentStopText;
    public GameObject currentInstructionsText;
    public GameObject currentPointer;

    //set enable/disable objects when scene begins
    private void Start()
    {
        currentStopText.gameObject.SetActive(false);
        currentInstructionsText.gameObject.SetActive(false);
        currentPointer.gameObject.SetActive(false);
    }

    //update objects on collision enter 
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Checkpoint")
        {
            currentStopText.gameObject.SetActive(true);
            currentInstructionsText.gameObject.SetActive(true);
            currentPointer.gameObject.SetActive(true);
        }
       
    }

    //update objects and begin screwdriver behavior on collision stay 
    public void OnTriggerStay(Collider other)
    {
        previousStopText.gameObject.SetActive(false);
        previousInstructionsText.gameObject.SetActive(false);
        previousPointer.gameObject.SetActive(false);

        if (other.gameObject.tag == "Collider")
        {
            StartCoroutine(screwdriverMotion());
        }
    }

    //screwdriver behavior and animation 
    IEnumerator screwdriverMotion()
    {
        screwdriverObject.transform.Rotate(0, rotateSpeed, 0);
        boltObject.transform.Translate(0, moveSpeed, 0);
        yield return new WaitForSeconds(0.01f);
    }

}
