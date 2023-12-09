using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeScreen : MonoBehaviour
{
    public bool fadeOnStart = true;
    public float fadeDuration = 1;
    public Color fadeColor;
    private Renderer rend;

    //get renderer when scene begins
    //fade into the scene
    void Start()
    {
        rend = GetComponent<Renderer>();
        if(fadeOnStart )
        {
            FadeIn();
        }
    }

    public void FadeIn()
    {
        Fade(1, 0);
    }

    public void FadeOut()
    {
        Fade(0, 1);
    }

    //begin fade behavior 
    public void Fade(float alphaIn, float alphaOut)
    {
        StartCoroutine(FadeRoutine(alphaIn, alphaOut));
    }
    
    //fade screen behavior coroutine
    public IEnumerator FadeRoutine(float alphaIn, float alphaOut)
    {
        float timer = 0; 
        while (timer <= fadeDuration)
        {
            Color newColor  = fadeColor;
            newColor.a = Mathf.Lerp(alphaIn, alphaOut, timer / fadeDuration);

            rend.material.SetColor("_BaseColor", newColor);

            timer += Time.deltaTime;
            yield return null;
        }
        Color newColor2 = fadeColor;
        newColor2.a = alphaOut;
        rend.material.SetColor("_BaseColor", newColor2);

    }
}
