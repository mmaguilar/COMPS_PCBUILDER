using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteScrewMotion : MonoBehaviour
{
    public FadeScreen fadeScreen;
    public int SceneToTransition;

    public GameObject screwdriverObject;
    public GameObject boltObject;

    public float rotateSpeed;
    public float moveSpeed;

    public GameObject previousStopText;
    public GameObject previousInstructionsText;
    public GameObject previousPointer;

    public GameObject currentStopText;
    public GameObject completedText;

    //hide text objects when scene begins 
    private void Start()
    {
        currentStopText.gameObject.SetActive(false);
        completedText.gameObject.SetActive(false);
    }

    //display text objects when entering collision 
    //transition to the next scene on collision
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Checkpoint")
        {
            currentStopText.gameObject.SetActive(true);
            completedText.gameObject.SetActive(true);
            GoToScene(SceneToTransition);
        }

    }

    //display text objects on collision stay 
    //being screwdriver behavior on collision
    public void OnTriggerStay(Collider other)
    {
        previousStopText.gameObject.SetActive(false);
        previousInstructionsText.gameObject.SetActive(false);
        previousPointer.gameObject.SetActive(false);

        if (other.gameObject.tag == "Collider")
        {
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

    //transition to new scene
    public void GoToScene(int scene)
    {
        StartCoroutine(GoToSceneRoutine(scene));
    }

    //fade into new scene 
    IEnumerator GoToSceneRoutine(int scene)
    {
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);

        //Launch the new Scene 
        SceneManager.LoadScene(scene);
    }
}
