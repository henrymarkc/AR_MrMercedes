using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class enableAnimations_vuforia : MonoBehaviour, ITrackableEventHandler

{

    private TrackableBehaviour mTrackableBehaviour;

    public Animator animationClips;


    void Start()

    {

        mTrackableBehaviour = GetComponent<TrackableBehaviour>();

        if (mTrackableBehaviour)

        {

            mTrackableBehaviour.RegisterTrackableEventHandler(this);

        }

    }

    public void OnTrackableStateChanged(

                                    TrackableBehaviour.Status previousStatus,

                                    TrackableBehaviour.Status newStatus)

    {

        if (newStatus == TrackableBehaviour.Status.DETECTED ||

            newStatus == TrackableBehaviour.Status.TRACKED ||

            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)

        {

            // Juego cuando se encuentra el objetivo

            //animationClips.enabled = true;
            /*animationClips = GetComponent<Animator>();
            animationClips.Play("CINEMA_4D_Main");*/
            
        }

        else

        {

            // Parar cuando se pierde el objetivo

            animationClips.enabled = false;

        }

    }

}
