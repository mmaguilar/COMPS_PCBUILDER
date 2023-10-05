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
    public GameObject warningPanel;

    private void Start()
    {
        warningPanel.SetActive(false);
    }
    
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "CPU Drop Zone")
        {
            print("MOBO" +  Motherboard.gameObject.transform.eulerAngles);
            print("CPU" +  HardwareInteractable.gameObject.transform.eulerAngles);
            if(HardwareInteractable.gameObject.transform.eulerAngles.x <= 50 && (HardwareInteractable.gameObject.transform.eulerAngles.y < 40 || HardwareInteractable.gameObject.transform.eulerAngles.y >= 300))
            {
                print("GOOD POSITION");
                warningPanel.SetActive(false);
            }
            else
            {
                warningPanel.SetActive(true);
              
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
