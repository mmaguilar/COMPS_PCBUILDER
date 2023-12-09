using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginScrewMotion : MonoBehaviour
{
    public GameObject screwdriverObject;
    public GameObject boltObject;

    public float rotateSpeed;
    public float moveSpeed;

    public GameObject startingInstructions;
    public GameObject startingPointer;

    public GameObject currentStopText;
    public GameObject currentInstructionsText;
    public GameObject currentPointer;

    //hide text objects when scene begins 
    private void Start()
    {
        currentStopText.gameObject.SetActive(false);
        currentInstructionsText.gameObject.SetActive(false);
        currentPointer.gameObject.SetActive(false);
    }

    //display text objects on entering collision
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Checkpoint")
        {
            currentStopText.gameObject.SetActive(true);
            currentInstructionsText.gameObject.SetActive(true);
            currentPointer.gameObject.SetActive(true);
        }

    }

    //display text objects on staying collision
    //Begin the screwdriver behavior on collision 
    public void OnTriggerStay(Collider other)
    {
        startingInstructions.gameObject.SetActive(false);
        startingPointer.gameObject.SetActive(false);
        if (other.gameObject.tag == "Collider")
        {
            StartCoroutine(screwdriverMotion());
        }
    }

    //Screwdriver behavior and animation
    IEnumerator screwdriverMotion()
    {
        screwdriverObject.transform.Rotate(0, rotateSpeed, 0);
        boltObject.transform.Translate(0, moveSpeed, 0);
        yield return new WaitForSeconds(0.01f);
    }

}
