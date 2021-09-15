using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControlVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 v3force;

    [SerializeField]
    KeyCode keypositive;

    [SerializeField]
    KeyCode keynegative;


    void FixedUpdate()//FixedUpdate exactly called 100 times per second
    {
        if (Input.GetKey(keypositive))
        {
            GetComponent<Rigidbody>().velocity += v3force;

        }

        if (Input.GetKey(keynegative))
        {
            GetComponent<Rigidbody>().velocity -= v3force;

        }
    }
}
