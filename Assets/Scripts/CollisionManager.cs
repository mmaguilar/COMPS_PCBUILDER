using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;


public class CollisionManager : MonoBehaviour
{


    public MeshRenderer invalidAlignmentText;
    public MeshRenderer validAlignmentText;

    
    void OnTriggerStay(Collider other)
    {
       if (other.gameObject.tag == "CPU")
       {
            invalidAlignmentText.enabled = true;
            validAlignmentText.enabled = true;
           /* //print("MOBO" +  Motherboard.gameObject.transform.eulerAngles);
            //print("CPU" +  HardwareInteractable.gameObject.transform.eulerAngles);
            if(HardwareInteractable.gameObject.transform.eulerAngles.x <= 50 && (HardwareInteractable.gameObject.transform.eulerAngles.y < 40 || HardwareInteractable.gameObject.transform.eulerAngles.y >= 300))
            {
                print("GOOD POSITION");
                invalidAlignmentText.enabled = false;
                validAlignmentText.enabled = true;
            }
            else
            {
                validAlignmentText.enabled = false;
                invalidAlignmentText.enabled = true;
              
            }
            */
        }

    }

 
}
