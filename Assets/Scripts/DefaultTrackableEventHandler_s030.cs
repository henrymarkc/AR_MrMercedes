/*==============================================================================
Copyright (c) 2019 PTC Inc. All Rights Reserved.

Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using UnityEngine;
using Vuforia;
using UnityEngine.Video;

/// <summary>
/// A custom handler that implements the ITrackableEventHandler interface.
///
/// Changes made to this file could be overwritten when upgrading the Vuforia version.
/// When implementing custom event handler behavior, consider inheriting from this class instead.
/// </summary>
public class DefaultTrackableEventHandler_s030 : MonoBehaviour, ITrackableEventHandler
{



    #region PROTECTED_MEMBER_VARIABLES

    protected TrackableBehaviour mTrackableBehaviour;
    protected TrackableBehaviour.Status m_PreviousStatus;
    protected TrackableBehaviour.Status m_NewStatus;
    //henry
    public ParticleSystem partSys;
    public ParticleSystem partSys_02;
    public Animator startAnim;
    public AudioSource aSource;
    public AudioClip aClip;
    public GameObject light01;
    public GameObject light02;
    public GameObject light03;
    public GameObject briefcase;
    //public videoPlayerController_script trailer; ////Script Ref
    public GameObject trailer_plane;
    public VideoPlayer videoPlayer;
    public Animator Vignette;
    //

    #endregion // PROTECTED_MEMBER_VARIABLES

    #region UNITY_MONOBEHAVIOUR_METHODS

    protected virtual void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
            mTrackableBehaviour.RegisterTrackableEventHandler(this);



    }

    protected virtual void OnDestroy()
    {
        if (mTrackableBehaviour)
            mTrackableBehaviour.UnregisterTrackableEventHandler(this);
    }

    #endregion // UNITY_MONOBEHAVIOUR_METHODS

    #region PUBLIC_METHODS

    /// <summary>
    ///     Implementation of the ITrackableEventHandler function called when the
    ///     tracking state changes.
    /// </summary>
    public void OnTrackableStateChanged(
    TrackableBehaviour.Status previousStatus,
    TrackableBehaviour.Status newStatus)
    {
        m_PreviousStatus = previousStatus;
        m_NewStatus = newStatus;

        Debug.Log("Trackable " + mTrackableBehaviour.TrackableName +
             " " + mTrackableBehaviour.CurrentStatus +
             " -- " + mTrackableBehaviour.CurrentStatusInfo);


        if (newStatus == TrackableBehaviour.Status.DETECTED ||
          newStatus == TrackableBehaviour.Status.TRACKED ||
          newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {

            //henry
            Vignette.Play("Vignette_transp");
            partSys.Play();
            partSys_02.Play();
            //partSys.Emit(500);
            aSource.PlayOneShot(aClip);
            startAnim.Play("CINEMA_4D_Main");
            light01.SetActive(false);
            light02.SetActive(false);
            light03.SetActive(true);

            //
            OnTrackingFound();

        }
        else if (previousStatus == TrackableBehaviour.Status.TRACKED &&
            newStatus == TrackableBehaviour.Status.NO_POSE)
        {
            Vignette.Play("Default");
            aSource.Stop();
            partSys.Stop();
            partSys.Clear();
            partSys_02.Stop();
            partSys_02.Clear();
            //partSys.Emit(0);
            //Logo.Play("Idle");
            startAnim.Play("Idle");
            //Flash.Play("Idle");
            briefcase.SetActive(false);
            //trailer.stopVideo();
            trailer_plane.SetActive(false);
            videoPlayer.Stop();
            OnTrackingLost();
        }
        else
        {
            // For combo of previousStatus=UNKNOWN + newStatus=UNKNOWN|NOT_FOUND
            // Vuforia is starting, but tracking has not been lost or found yet
            // Call OnTrackingLost() to hide the augmentations
            OnTrackingLost();
        }
    }

    #endregion // PUBLIC_METHODS

    #region PROTECTED_METHODS

    protected virtual void OnTrackingFound()
    {
        if (mTrackableBehaviour)
        {
            var rendererComponents = mTrackableBehaviour.GetComponentsInChildren<Renderer>(true);
            var colliderComponents = mTrackableBehaviour.GetComponentsInChildren<Collider>(true);
            var canvasComponents = mTrackableBehaviour.GetComponentsInChildren<Canvas>(true);

            //startAnim.Play("CINEMA_4D_Main");

            // Enable rendering:
            foreach (var component in rendererComponents)
                component.enabled = true;

            // Enable colliders:
            foreach (var component in colliderComponents)
                component.enabled = true;

            // Enable canvas':
            foreach (var component in canvasComponents)
                component.enabled = true;
        }
    }


    protected virtual void OnTrackingLost()
    {
        if (mTrackableBehaviour)
        {
            var rendererComponents = mTrackableBehaviour.GetComponentsInChildren<Renderer>(true);
            var colliderComponents = mTrackableBehaviour.GetComponentsInChildren<Collider>(true);
            var canvasComponents = mTrackableBehaviour.GetComponentsInChildren<Canvas>(true);

            // Disable rendering:
            foreach (var component in rendererComponents)
                component.enabled = false;

            // Disable colliders:
            foreach (var component in colliderComponents)
                component.enabled = false;

            // Disable canvas':
            foreach (var component in canvasComponents)
                component.enabled = false;
        }
    }

    #endregion // PROTECTED_METHODS
}