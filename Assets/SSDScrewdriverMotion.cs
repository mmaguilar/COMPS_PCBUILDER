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

    public GameObject StartText;
    public GameObject NextScrewText;
    public GameObject StopText;
    public GameObject CompletedText;

    public FadeScreen fadeScreen;
    public int SceneToTransition;


    public void Start()
    {
        NextScrewText.gameObject.SetActive(false);
        StopText.gameObject.SetActive(false);
        CompletedText.gameObject.SetActive(false);  
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Checkpoint1")
        {
            StopText.gameObject.SetActive(true);
            NextScrewText.gameObject.gameObject.SetActive(true);
        }else if(other.gameObject.tag == "Checkpoint2")
        {
            StopText.gameObject.SetActive(false);
            NextScrewText.gameObject.SetActive(false);
            CompletedText.gameObject.SetActive(true);
            GoToScene(SceneToTransition);
        }
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Collider")
        {
            StartText.gameObject.SetActive(false);
            StartCoroutine(screwdriverMotion());
        }
    }

    IEnumerator screwdriverMotion()
    {
        screwdriverObject.transform.Rotate(0, rotateSpeed, 0);
        boltObject.transform.Translate(0, moveSpeed, 0);
        yield return new WaitForSeconds(0.01f);
    }

    public void GoToScene(int scene)
    {
        StartCoroutine(GoToSceneRoutine(scene));
    }

    IEnumerator GoToSceneRoutine(int scene)
    {
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);

        //Launch the new Scene 
        SceneManager.LoadScene(scene);
    }

}
