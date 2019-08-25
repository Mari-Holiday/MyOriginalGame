using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Effects applied to the entire screen.
 */
public class PostEffect_Camera : MonoBehaviour
{
    //Put material with shader of "black and white" from inspector.
    [SerializeField]
    Material grayscale;

    //This message is called after all objects have been rendered.
    void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        //Put src * grayscale in dest
        Graphics.Blit(src, dest, grayscale);
    }


}
