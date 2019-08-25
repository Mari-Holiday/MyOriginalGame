using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

/*
　Class for whole screen changes (almost for UI)
 */

public class ScreenChange : MonoBehaviour
{
    public CanvasGroup canvasGroup;

    public void CanvasEaseOut()
    {
        //Dissipate the canvas slowly.
        DOTween.To(
            () => canvasGroup.alpha,
            num => canvasGroup.alpha = num,
            0,
            1.0f
        ).SetEase(Ease.InSine);
    }

}