using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameeraController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            Move(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Move(-Vector3.forward);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            Move(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Move(Vector3.right);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Move(Vector3.up);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Move(Vector3.down);
        }
    }

    private void Move(Vector3 dir)
    {
        transform.position = transform.position + dir / 30;
    }
}
