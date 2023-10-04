using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CollisionManager : MonoBehaviour
{
    /* void OnTriggerEnter(Collider other)
     {
         if(other.gameObject.tag == "CPU Drop Zone")
         {
             print("Enter");
         }

     }*/


    public GameObject Motherboard;
    public GameObject HardwareInteractable;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "CPU Drop Zone")
        {
            print("MOBO" +  Motherboard.gameObject.transform.eulerAngles);
            print("CPU" +  HardwareInteractable.gameObject.transform.eulerAngles);
            if(HardwareInteractable.gameObject.transform.eulerAngles.x <= 50)
            {
                print("GOOD POSITION");
            }
            else
            {
          
            }
        }

    }

    /* void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "CPU Drop Zone")
        {
            print("Exit");
        }
    }*/
}
