using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class ScrewMotion : MonoBehaviour
{
    public ActionBasedController leftController;
    public ActionBasedController rightController;


    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Collider")
        {
           //start coroutine here 
            
        }
    }

}
