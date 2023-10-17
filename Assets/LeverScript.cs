using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : MonoBehaviour
{
    public GameObject fixedLever;

    // Start is called before the first frame update
    void Start()
    {
        fixedLever.gameObject.SetActive(false);
    }

}
