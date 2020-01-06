using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muzzleFlash_script : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {
        
    }

    public GameObject light01;
    public GameObject light02;
    public GameObject light03;
    public GameObject light04;

    public void TurnOn()
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
