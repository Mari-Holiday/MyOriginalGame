using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class sample : MonoBehaviour
{
    //public Animator animator;

    public PlayableDirector playableDirector;

    public void StartAnimator()
    {
        playableDirector.Play();
    }
}
