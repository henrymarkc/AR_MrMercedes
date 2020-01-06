using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneManager_s010 : MonoBehaviour
{
    public static bool flag_01;
    public static bool flag_02;
    public static bool flag_03;

    public ParticleSystem partSys;
    public ParticleSystem partSys_02;

    /*public GameObject light01;
    public GameObject light02;
    public GameObject light03;*/
    /*
        public void s010_on()
        {
            light01.SetActive(false);
            light02.SetActive(true);
            light03.SetActive(false);
        }

        public void s030_on()
        {
            light01.SetActive(false);
            light02.SetActive(false);
            light03.SetActive(true);
        }
        */
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        partSys.Stop();
        partSys_02.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
