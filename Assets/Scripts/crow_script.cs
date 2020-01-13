using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class crow_script : MonoBehaviour
{

    public VideoPlayer videoPlayer;
    public GameObject crow1;
    public GameObject crow2;
    public GameObject crow3;
    public GameObject crow4;
    public GameObject crow5;
    Animator crow1Anim;
    Animator crow2Anim;
    Animator crow3Anim;
    Animator crow4Anim;
    Animator crow5Anim;


    public void CrowHide() {
        crow1.SetActive(false);
        crow2.SetActive(false);
        crow3.SetActive(false);
        crow4.SetActive(false);
        crow5.SetActive(false);
        //Debug.Log("iS wORKING");
    }

    // Start is called before the first frame update
   
    
    void Start()
    {
        crow1Anim = crow1.GetComponent<Animator>();
        crow2Anim = crow2.GetComponent<Animator>();
        crow3Anim = crow3.GetComponent<Animator>();
        crow4Anim = crow4.GetComponent<Animator>();
        crow5Anim = crow5.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (videoPlayer.frame == 48)
        {
            //public void TurnOn();
           
            crow1.SetActive(true);          
            crow1Anim.Play("CrowIdle");
            //crow1Anim.Play("CrowFlight");
            
        }

        if (videoPlayer.frame == 60)
        {
            crow2.SetActive(true);
            
            crow2Anim.Play("CrowIdle");

        }

        if (videoPlayer.frame == 90)
        {
            crow3.SetActive(true);           
            crow3Anim.Play("CrowIdle");
        }

        if (videoPlayer.frame == 103)
        {
            crow4.SetActive(true);          
            crow4Anim.Play("CrowIdle");          
            crow5.SetActive(true);           
            crow5Anim.Play("CrowIdle");
        }
        
        if (videoPlayer.frame == 224)
        {
        
            crow1Anim.Play("CrowFlight");
            crow1Anim.Play("Crow_01_flightPath");
            crow2Anim.Play("CrowFlight");
            crow2Anim.Play("Crow_02_flightPath");
            crow3Anim.Play("CrowFlight");
            crow3Anim.Play("Crow_03_flightPath");
            crow4Anim.Play("CrowFlight");
            crow4Anim.Play("Crow_04_flightPath");
            crow5Anim.Play("CrowFlight");
            crow5Anim.Play("Crow_05_flightPath");

        }
    }
}
