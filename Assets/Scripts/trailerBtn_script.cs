using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class trailerBtn_script : MonoBehaviour
{
    public GameObject trailer_plane;
    public VideoPlayer videoPlayer;
    public Texture Blank;

    public void OnMouseDown() {

        //trailer.SetActive(!trailer.activeSelf);
        //Video cache frame fix //
        videoPlayer.targetTexture.DiscardContents();
        videoPlayer.targetTexture.Release();
        Graphics.Blit(Blank, videoPlayer.targetTexture);
        // End Fix
        trailer_plane.SetActive(true);
        videoPlayer.time = 0;
        videoPlayer.Play();
    }


    void Start()
    {
        // Video finished playing
        videoPlayer.loopPointReached += EndReached;

    }


    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        // Close video screen
        //Debug.Log("End Reached");
        //videoPlayer.time = 0;
        videoPlayer.Stop();
        //trailer_plane.SetActive(false);
    }

}
