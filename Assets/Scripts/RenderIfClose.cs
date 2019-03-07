using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderIfClose : MonoBehaviour {

     public Transform player;

    private void Update()
    {
        if(Vector3.Distance(player.position, transform.position) < 97)
        {
            GetComponent<MeshRenderer>().enabled = true;
        }
        else
        {
            GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
