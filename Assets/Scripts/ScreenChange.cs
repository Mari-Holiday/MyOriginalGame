using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenChange : MonoBehaviour
{
    public CanvasGroup canvasGroup;

    public void CanvasEaseOut()
    {
       canvasGroup.alpha = 0;
    }

}