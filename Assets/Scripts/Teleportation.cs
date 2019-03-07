using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{

    public GameObject player;
    public GameObject goTo;
    static bool isOverlapping = true;

     Vector3 translation;
     Vector3 rotationTranslation;
     float rotDiff;
     bool useTranslation;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (isOverlapping)
            {
                player.transform.position = new Vector3(goTo.transform.position.x, goTo.transform.position.y - 1 + 0.5189f, goTo.transform.position.z);
            }
            //    if (isOverlapping && !useTranslation)
            //    {

            //        isOverlapping = false;
            //        Vector3 portalToPlayer = player.transform.position - portCam.portal.position;
            //        float dotProduct = Vector3.Dot(transform.up, portalToPlayer);
            //        player.transform.position = player.transform.position + (portCam.otherPortal.position - transform.position);

            //        StartCoroutine(Toogling());
            //        if(dotProduct <= 0.1)
            //        {
            //            float rotationDiff = -Quaternion.Angle(portCam.portal.rotation, portCam.otherPortal.rotation);
            //            rotationDiff += 180;
            //            player.transform.Rotate(Vector3.up, rotationDiff);
            //            Vector3 positionOffset = Quaternion.Euler(0f, rotationDiff, 0f) * portalToPlayer;
            //            player.transform.position = portCam.otherPortal.position + positionOffset;
            //        }

            //    }
            //    else if(isOverlapping)
            //    {
            //        //player.transform.position = player.transform.position + translation;

            //        player.transform.position = new Vector3(goTo.transform.position.x, goTo.transform.position.y - 1+0.5189f, goTo.transform.position.z);
            //        print(goTo.transform.position.y - 1+0.5189f);
            //        //player.transform.rotation = player.transform.rotation * Quaternion.Euler(rotationTranslation);
            //        //player.transform.Rotate(Vector3.up, rotDiff);
            //    }

            //}
        }
    }

    IEnumerator Toogling()
    {
        yield return new WaitForSeconds(0.1f);
        isOverlapping = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            

        }
    }
    private void Update()
    {
        
        
    }
}
