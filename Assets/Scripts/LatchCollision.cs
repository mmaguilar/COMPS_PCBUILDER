using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class LatchCollision : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;

    public GameObject top;
    public GameObject fixedTop;

    public GameObject lever;

    //set objects disabled or enabled when scene starts
    public void Start()
    {
        text1.gameObject.SetActive(true);
        text2.gameObject.SetActive(false);

        lever.gameObject.SetActive(false);

        fixedTop.gameObject.SetActive(false);
        top.gameObject.SetActive(true);

    }
    //update text objects active/disactive on collision stay
    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Collider")
        {
            text1.gameObject.SetActive(false);
            text2.gameObject.SetActive(true);

            lever.gameObject .SetActive(true);

            fixedTop.gameObject.SetActive(true);
            top.gameObject.SetActive(false);

        }
    }

}
