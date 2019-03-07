using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeringApparition : MonoBehaviour
{
    public List<GameObject> objectsToAppear;
    public List<GameObject> objectsToDisapear;

    private void OnTriggerEnter(Collider other)
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
}
