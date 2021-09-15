using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 v3force;

    void FixedUpdate()//FixedUpdate exactly called 100 times per second
    {
        GetComponent<Rigidbody>().velocity += v3force;
    }
}
