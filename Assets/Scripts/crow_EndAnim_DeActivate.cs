using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crow_EndAnim_DeActivate : MonoBehaviour
{
    // Start is called before the first frame update

    Animator anim;

    private void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();

    }


    public void Crow_01_DeActivate() {
        //anim = gameObject.GetComponent<Animation>();
        //gameObject.GetComponent<Animator>().playbackTime
        //anim.Play("Crow_01_flightPath", -1, 0f);
        // Animator.Play(state, layer, normalizedTime)
        //anim = this.gameObject.GetComponent<Animation>();
        //anim["Crow_01_flightPath"].time = 0.0f;
        //anim.Play("Crow_01_reset");
        gameObject.SetActive(false);
        //Debug.Log("Crow01_test");
    }

    public void Crow_02_DeActivate()
    {
        /*anim = gameObject.GetComponent<Animation>();
        anim["Crow_02_flightPath"].time = 0.0f;*/
        gameObject.SetActive(false);
        //Debug.Log("Crow02_test");
    }

    public void Crow_03_DeActivate()
    {
        /*anim = gameObject.GetComponent<Animation>();
        anim["Crow_03_flightPath"].time = 0.0f;*/
        gameObject.SetActive(false);
        //Debug.Log("Crow03_test");
    }

    public void Crow_04_DeActivate()
    {    
        /*anim = gameObject.GetComponent<Animation>();
        anim["Crow_04_flightPath"].time = 0.0f;*/
        gameObject.SetActive(false);
        //Debug.Log("Crow04_test");
    }

    public void Crow_05_DeActivate()
    {    
        /*anim = gameObject.GetComponent<Animation>();
        anim["Crow_05_flightPath"].time = 0.0f;*/
        gameObject.SetActive(false);
        //Debug.Log("Crow05_test");
    }

   


}
