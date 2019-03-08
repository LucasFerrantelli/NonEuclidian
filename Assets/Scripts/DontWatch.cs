using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontWatch : MonoBehaviour
{
    public List<GameObject> objectsToAppear;
    public List<GameObject> objectsToDisapear;

    public bool noRevert;

    private void FixedUpdate()
    {
        Debug.DrawLine(transform.position, Camera.main.transform.position);
        if (Physics.Linecast(transform.position, Camera.main.transform.position))
        {
            if(noRevert)
            {

            }
            else
            {
                IsNotSeen();
            }
            
        }
        else
        {
            IsSeen();
        }
    }

    void IsSeen()
    {
        for (int i = 0; i < objectsToAppear.Count; i++)
        {
            objectsToAppear[i].SetActive(true);
        }
        for (int i = 0; i < objectsToDisapear.Count; i++)
        {
            objectsToDisapear[i].SetActive(false);
        }
    }

    void IsNotSeen()
    {
        for (int i = 0; i < objectsToAppear.Count; i++)
        {
            objectsToAppear[i].SetActive(false);
        }
        for (int i = 0; i < objectsToDisapear.Count; i++)
        {
            objectsToDisapear[i].SetActive(true);
        }
    }
}

