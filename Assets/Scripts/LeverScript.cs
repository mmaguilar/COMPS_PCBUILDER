using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : MonoBehaviour
{
    public GameObject fixedLever;

    //Disable object when the scene begins 
    void Start()
    {
        fixedLever.gameObject.SetActive(false);
    }

}
