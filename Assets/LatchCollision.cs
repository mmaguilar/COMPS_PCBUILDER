using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LatchCollision : MonoBehaviour
{
    public FadeScreen fadeScreen;

    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Collider")
        {

            GoToScene(0);
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
