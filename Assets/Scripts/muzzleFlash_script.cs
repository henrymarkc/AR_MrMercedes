
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class muzzleFlash_script : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject light01;
    public GameObject light02;
    public GameObject light03;
    public GameObject light04;
    public VideoPlayer videoPlayer;

    void Start()
    {
        
    }


    /*public void TurnOn()
    {
        light01.SetActive(true);
        light02.SetActive(true);
        light03.SetActive(true);
        light04.SetActive(true);
    }

    public void TurnOff()
    {
        light01.SetActive(false);
        light02.SetActive(false);
        light03.SetActive(false);
        light04.SetActive(false);
    }*/

    // Update is called once per frame
    void Update()
    {
        if (videoPlayer.frame == 223)
        {
            //public void TurnOn();
            light01.SetActive(true);
            light02.SetActive(true);
            light03.SetActive(true);
            light04.SetActive(true);
        }

        if (videoPlayer.frame == 225)
        {

            light01.SetActive(false);
            light02.SetActive(false);
            light03.SetActive(false);
            light04.SetActive(false);
        }

    }
}
