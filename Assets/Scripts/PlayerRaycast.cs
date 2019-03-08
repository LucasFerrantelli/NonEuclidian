using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    RaycastHit hit;
    Ray ray;

    void Update()
    {
        if(Input.GetKey("e"))
        {
            ray = Camera.main.ScreenPointToRay(new Vector3 (1,0,0) );
      
            

            if (Physics.Raycast(ray, out hit,10f))
            {
                Debug.Log(hit.collider.gameObject.name);
                Debug.DrawRay(Camera.main.transform.position, Vector3.forward,Color.green) ;
            }

        }
    }
}
