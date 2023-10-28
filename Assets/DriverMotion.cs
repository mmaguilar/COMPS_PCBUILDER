using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverMotion : MonoBehaviour
{
    public GameObject screwdriverObject;
    public float rotateSpeed;

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Collider")
        {
            print("driver");
        }
    }
}
