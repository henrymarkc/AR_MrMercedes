using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startAnim_script : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator startAnim;

    void Start()
    {
        startAnim = GetComponent<Animator>();
     
    }
    
    public void PlayIt() {
        startAnim.Play("CINEMA_4D_Main");
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
