using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RAMAlignment : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Collider")
        {
            print("Aligned");
        }
    }
}
