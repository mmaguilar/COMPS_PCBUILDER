using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeverCollision : MonoBehaviour
{

    public GameObject text2; 
    public GameObject text3;

    public GameObject lever;
    public GameObject fixedLever;

    public FadeScreen fadeScreen;

    public void Start()
    {
        text3.gameObject.SetActive(false);
        fixedLever.gameObject.SetActive(false);
    }

    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "LeverCollider")
        {
            text2.gameObject.SetActive(false);
            text3.gameObject.SetActive(true);

            lever.gameObject.SetActive(false);
            fixedLever.gameObject.SetActive(true);

            GoToScene(3);
        }
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
