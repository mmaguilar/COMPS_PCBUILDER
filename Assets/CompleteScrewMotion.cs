using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteScrewMotion : MonoBehaviour
{
    public GameObject screwdriverObject;
    public GameObject boltObject;

    public float rotateSpeed;
    public float moveSpeed;

    public GameObject previousStopText;
    public GameObject previousInstructionsText;
    public GameObject previousPointer;

    public GameObject currentStopText;
    public GameObject completedText;

    private void Start()
    {
        currentStopText.gameObject.SetActive(false);
        completedText.gameObject.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Checkpoint")
        {
            currentStopText.gameObject.SetActive(true);
            completedText.gameObject.SetActive(true);
        }

    }

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

    IEnumerator screwdriverMotion()
    {
        screwdriverObject.transform.Rotate(0, rotateSpeed, 0);
        boltObject.transform.Translate(0, moveSpeed, 0);
        yield return new WaitForSeconds(0.01f);
    }

}
