using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoboScrewMotion : MonoBehaviour
{
    public GameObject screwdriverObject;
    public GameObject boltObject;

    public float rotateSpeed;
    public float moveSpeed;

    public GameObject pointer;
    public GameObject completeText;

    public void Start()
    {
        completeText.SetActive(false);
    }

    //verify collision and update text object
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Checkpoint")
        {
            completeText.gameObject.SetActive(true);
        }
    }

    //verify collision and begin screwing motion
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Collider")
        {
            pointer.gameObject.SetActive(false);
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
