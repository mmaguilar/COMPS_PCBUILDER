using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SSDScrewdriverMotion : MonoBehaviour
{
    public GameObject screwdriverObject;
    public GameObject boltObject;

    public float rotateSpeed;
    public float moveSpeed;

    public GameObject ScrewText;
    public GameObject CompletedText;

    public FadeScreen fadeScreen;
    public int SceneToTransition;

    public void Start()
    {
        CompletedText.gameObject.SetActive(false);  
    }

    //verify and transition to a new scene on collision enter
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Checkpoint1")
        {
            CompletedText.gameObject.SetActive(true);
            GoToScene(SceneToTransition);
        }
    }

    //verify and transition to a new scene on collision stay 
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Collider")
        {
            ScrewText.gameObject.SetActive(false);
            StartCoroutine(screwdriverMotion());
        }
    }

    //screwdriver behavior and animation 
    IEnumerator screwdriverMotion()
    {
        screwdriverObject.transform.Rotate(0, rotateSpeed, 0);
        boltObject.transform.Translate(0, moveSpeed, 0);
        yield return new WaitForSeconds(0.01f);
    }

    //transition to a new scene 
    public void GoToScene(int scene)
    {
        StartCoroutine(GoToSceneRoutine(scene));
    }

    //fade into a new scene 
    IEnumerator GoToSceneRoutine(int scene)
    {
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);

        //Launch the new Scene 
        SceneManager.LoadScene(scene);
    }

}
