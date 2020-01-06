using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s030_briefcasePopUp : MonoBehaviour
{



    public GameObject briefcase;
    
    // Start is called before the first frame update
    void Start()
    {
        //TurnOnBrief();
    }


    public void TurnOnBrief()
    {
        briefcase.SetActive(true);
    }

    public void TurnOffBrief()
    {
        briefcase.SetActive(false);
    }


        // Update is called once per frame
        void Update()
    {
        
    }
}
