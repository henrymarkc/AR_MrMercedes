using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class typeWriter_anim_script : MonoBehaviour
{

    public VideoPlayer videoPlayer;
    public Animator startAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(videoPlayer.frame);
        if (videoPlayer.frame == 30) 
        {
            startAnim.Play("PostIt");
            //Debug.Log("Ohh yeah");
        }

        if (videoPlayer.frame == 57)
        {
            startAnim.Play("PostIt_02");
            
        }

        if (videoPlayer.frame == 93)
        {
            startAnim.Play("PostIt_03");
            
        }
    }
}
