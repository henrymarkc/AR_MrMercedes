using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videoPlayerController_script : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    public void playVideo()
    {
        videoPlayer.time = 0;
        videoPlayer.Play();
    }
    
    public void stopVideo()
    {
        videoPlayer.time = 0;
        videoPlayer.Stop();
    }

    void Start()
    {
        // Video finished playing
        videoPlayer.loopPointReached += EndReached;

    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        // Close video screen
        Debug.Log("End Reached");

    }

}
