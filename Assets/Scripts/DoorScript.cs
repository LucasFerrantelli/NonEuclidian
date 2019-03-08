using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class DoorScript : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        if(Vector3.Distance(transform.position, Camera.main.transform.position)< 3 && Input.GetKeyDown("e"))
        {
            anim.Play("DoorAnim");
        }
    }

}
