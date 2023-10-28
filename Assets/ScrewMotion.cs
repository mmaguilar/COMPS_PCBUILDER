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

    public GameObject nextStopText;
    public GameObject nextInstructionsText;
    public GameObject nextPointer;

    private void Start()
    {
        currentStopText.gameObject.SetActive(false);
        currentInstructionsText.gameObject.SetActive(false);
        currentPointer.gameObject.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Checkpoint")
        {
            currentStopText.gameObject.SetActive(true);
            currentInstructionsText.gameObject.SetActive(true);
            currentPointer.gameObject.SetActive(true);
        }
       
    }

    public void OnTriggerStay(Collider other)
    {
        if(previousStopText.gameObject != null && previousInstructionsText.gameObject != null && previousPointer != null)
        {
            previousStopText.gameObject.SetActive(false);
            previousInstructionsText.gameObject.SetActive(false);
            previousPointer.gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Collider")
        {
            StartCoroutine(screwdriverMotion());
        }
    }

    IEnumerator screwdriverMotion()
    {
        screwdriverObject.transform.Rotate(0, rotateSpeed, 0);
        boltObject.transform.Translate(0, moveSpeed, 0);
        yield return new WaitForSeconds(0.01f);
    }

}
