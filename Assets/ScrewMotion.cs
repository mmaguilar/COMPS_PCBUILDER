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


    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Collider")
        {
            StartCoroutine(screwdriverMotion());
        }
        if(other.gameObject.tag == "Finished Collider")
        {
            StopCoroutine(screwdriverMotion());
        }
    }

    IEnumerator screwdriverMotion()
    {
        screwdriverObject.transform.Rotate(0, rotateSpeed, 0);
        boltObject.transform.Translate(0, moveSpeed, 0);
        yield return new WaitForSeconds(1);
    }





}
