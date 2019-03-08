using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HubTeleportScript : MonoBehaviour
{
    private GameObject player;

    private void Start()
    {
        player = GameObject.Find("FPSController");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("ça entre");
            player.transform.position = new Vector3 (player.transform.position.x, 10,player.transform.position.z);

        }
        
    }
}
