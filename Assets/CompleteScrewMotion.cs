using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteScrewMotion : MonoBehaviour
{
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Finished Collider")
        {
            print("Finished");
            StopAllCoroutines();
        }
    }
}
